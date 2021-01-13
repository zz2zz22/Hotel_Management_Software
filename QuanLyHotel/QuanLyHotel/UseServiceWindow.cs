using roomServiceBUS;
using roomserviceDTO;
using serviceBUS;
using serviceDTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyHotel
{
    public partial class UseServiceWindow : Form
    {
        public UseServiceWindow()
        {
            InitializeComponent();
            //this.loadData();
        }
        public UseServiceWindow(string name, string kind, string bedamount)
        {
            InitializeComponent();
            //this.loadData();
            lbNameRoom.Text = name;
            lbKindRoom.Text = kind;
            lbBedsAmount.Text = bedamount;
        }
        private ServiceBUS srvBus;
        private RoomServiceBUS roomServiceBUS;
        private Double cost = 0;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            srvBus = new ServiceBUS();
            List<ServiceDTO> list = srvBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvService.Columns.Clear();
            dtgvService.DataSource = null;

            dtgvService.AutoGenerateColumns = false;
            dtgvService.AllowUserToAddRows = false;
            dtgvService.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(KIND);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvService.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData(List<ServiceDTO> list)
        {
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvService.Columns.Clear();
            dtgvService.DataSource = null;

            dtgvService.AutoGenerateColumns = false;
            dtgvService.AllowUserToAddRows = false;
            dtgvService.DataSource = list;

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(NAME);

            DataGridViewTextBoxColumn KIND = new DataGridViewTextBoxColumn();
            KIND.Name = "kind";
            KIND.HeaderText = "Kind";
            KIND.DataPropertyName = "kind";
            KIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(KIND);

            DataGridViewTextBoxColumn COST = new DataGridViewTextBoxColumn();
            COST.Name = "cost";
            COST.HeaderText = "Cost";
            COST.DataPropertyName = "cost";
            COST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvService.Columns.Add(COST);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvService.DataSource];
            myCurrencyManager.Refresh();


        }
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void TxtNumberService_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider3.SetError(txtNumberService, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void btLoadCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchService.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchService.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<ServiceDTO> listTimKiem = srvBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<ServiceDTO> listTimKiem = srvBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void dtgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            lbNameService.Text = dtgvService.Rows[numrow].Cells[0].Value.ToString();
            lbKindService.Text = dtgvService.Rows[numrow].Cells[1].Value.ToString();
            lbCost.Text = dtgvService.Rows[numrow].Cells[2].Value.ToString();

        }

        private void btUseService_Click(object sender, EventArgs e)
        {
            if (lbNameRoom.Text == "")
            {
                if (lbKindRoom.Text == "")
                {
                    if (lbBedsAmount.Text == "")
                    {
                        MessageBox.Show("Please choose a room first !");
                        this.Close();
                    }
                }

            }
            else
            {
                errorProvider1.Clear();

                if (txtNumberService.Text == "")
                {
                    errorProvider1.SetError(txtNumberService, "not null!");
                }

                else
                {
                    roomServiceBUS = new RoomServiceBUS();
                    RoomServiceDTO roomService = new RoomServiceDTO();
                    //Sửa biến để kg trùng service
                    roomService.IDR_S = lbNameRoom.Text + "@" + lbNameService.Text + "@" + DateTime.Now;
                    roomService.IDR = lbNameRoom.Text;
                    roomService.IDS = lbNameService.Text;
                    roomService.TIME = DateTime.Parse(dtDateService.Text);
                    roomService.NUMBER = int.Parse(txtNumberService.Text);
                    roomService.COST = Decimal.Parse(lbCost.Text) * Decimal.Parse(txtNumberService.Text);
                    decimal Totalcost = Decimal.Parse(lbCost.Text) * Decimal.Parse(txtNumberService.Text);
                    bool kq = roomServiceBUS.add(roomService);
                    if (kq == false)
                        MessageBox.Show("Fail!");
                    else
                        MessageBox.Show("Sussces");
                    this.loadData();
                    

                    string fileLPath = @"file.txt";
                    string[] lines;
                    string fileText = "";
                    lines = System.IO.File.ReadAllLines(fileLPath);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        fileText += lines[i] + "\n";
                    }
                    string str = fileText + lbNameService.Text + "\t" + "Service" + "\t" + dtDateService.Text + "\t" + Totalcost.ToString() + "\t" + lbKindService.Text;

                    System.IO.File.WriteAllText(fileLPath, str);


                    //Chuyển this.Close vào để chạy errorProvider
                    this.Close();
                }
            }
        }

        private void UseServiceWindow_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void lbKindService_SelectedValueChanged(object sender, EventArgs e)
        {
            lbNameService.Items.Clear();
            foreach (DataGridViewRow row in dtgvService.Rows)
            {
                if (row.Cells[1].Value.ToString() == lbKindService.Text)
                {
                    lbNameService.Items.Add(row.Cells[0].Value.ToString());
                }
            }
        }

        private void lbNameService_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvService.Rows)
            {
                if (row.Cells[0].Value.ToString() == lbNameService.Text)
                {
                    lbCost.Text = row.Cells[2].Value.ToString();
                    cost = Double.Parse(lbCost.Text);
                }
            }
        }

        private void txtNumberService_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberService.Text != null)
            {
                if (lbCost.Text != null)
                {

                        lbCost.Text = (Double.Parse(txtNumberService.Text) * cost).ToString();
                }
                else
                {
                    lbCost.Text = "0";                       
                }    
            }
            else
            {
                lbCost.Text = cost.ToString();
            }
        }

        #endregion
        //
    }
}
