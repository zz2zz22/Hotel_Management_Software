using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using billBUS;
using billDTO;
using customerBUS;
using customerDTO;
using roomDTO;
using roomBUS;

namespace QuanLyHotel
{
    public partial class CheckInWindow : Form
    {
        public CheckInWindow()
        {
            InitializeComponent();
        }
        public CheckInWindow(string name, string kind, string bedamount, string cost)
        {
            InitializeComponent();
            //level = Level;
            lbNameRoom.Text = name;
            lbKind.Text = kind;
            lbBedsAmount.Text = bedamount;
            lbCost.Text = cost;
            //this.loadData();
        }
        private bool isExsit = false, nameCheck = false;
        private CustomerBUS ctmBus;
        private RoomBUS rmBUS;
        private BillBUS bllBUS;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            ctmBus = new CustomerBUS();
            List<CustomerDTO> list = ctmBus.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvCustomer.Columns.Clear();
            dtgvCustomer.DataSource = null;

            dtgvCustomer.AutoGenerateColumns = false;
            dtgvCustomer.AllowUserToAddRows = false;
            dtgvCustomer.DataSource = list;



            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(NAME);


            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "Phone";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(pHONE);



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvCustomer.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData(List<CustomerDTO> list)
        {
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvCustomer.Columns.Clear();
            dtgvCustomer.DataSource = null;

            dtgvCustomer.AutoGenerateColumns = false;
            dtgvCustomer.AllowUserToAddRows = false;
            dtgvCustomer.DataSource = list;



            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(NAME);


            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "Phone";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvCustomer.Columns.Add(pHONE);



            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvCustomer.DataSource];
            myCurrencyManager.Refresh();


        }
        #endregion
        //
        //---- EVENTS
        //

        
        #region Events
        private void BtCheckIn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            TimeSpan a = dtCheckOut.Value.Subtract(dtCheckIn.Value);
            
            if (txtBoxCustomerName.Text == "")
            {
                errorProvider1.SetError(txtBoxCustomerName, "not null!");
            }
            else if (txtBoxCustomerID.Text == "")
            {
                errorProvider2.SetError(txtBoxCustomerID, "not null!");
            }
            else if (txtBoxCustomerPhone.Text == "")
            {
                errorProvider3.SetError(txtBoxCustomerPhone, "not null!");
            }
            else
            {
                //ko bấm load
                if (isExsit == false)
                {
                    foreach (DataGridViewRow row in dtgvCustomer.Rows)
                    {
                        //click vào load nhưng trùng tên
                        if (row.Cells[0].Value.ToString() == txtBoxCustomerName.Text)
                        {
                            nameCheck = true;
                            MessageBox.Show("Khách hàng đã tồn tại, sẽ dùng dữ liệu đã tồn tại của khách hàng!");
                        }
                    }
                    if (nameCheck == false)
                    {
                        ctmBus = new CustomerBUS();
                        CustomerDTO ctm = new CustomerDTO();
                        ctm.IDC = txtBoxCustomerName.Text;
                        ctm.NAME = txtBoxCustomerName.Text;
                        ctm.PHONE = txtBoxCustomerPhone.Text;
                        ctm.DATE = DateTime.Parse(dtCheckIn.Text);
                        ctm.CMND = txtBoxCustomerID.Text;
                        bool kq2 = ctmBus.add(ctm);
                    }
                }
                //bấm load
                if (isExsit == true)
                {
                    //click vào load
                    foreach (DataGridViewRow row in dtgvCustomer.Rows)
                    {
                        //click vào load nhưng trùng tên
                        if (row.Cells[0].Value.ToString() == txtBoxCustomerName.Text)
                        {
                            nameCheck = true;
                        }
                    }
                    if (nameCheck == false)
                    {
                        ctmBus = new CustomerBUS();
                        CustomerDTO ctm = new CustomerDTO();
                        ctm.IDC = txtBoxCustomerName.Text;
                        ctm.NAME = txtBoxCustomerName.Text;
                        ctm.PHONE = txtBoxCustomerPhone.Text;
                        ctm.DATE = DateTime.Parse(dtCheckIn.Text);
                        ctm.CMND = txtBoxCustomerID.Text;
                        bool kq2 = ctmBus.add(ctm);
                    }
                }
                  

                //Thêm điều kiện khi chưa chọn Room
                if (lbNameRoom.Text == "")
                {
                    if (lbKind.Text == "")
                    {
                        if (lbBedsAmount.Text == "")
                        {
                            if (lbCost.Text == "")
                            {
                                MessageBox.Show("Please choose a room first !");
                                this.Close();

                            }
                        }
                    }

                }
                else
                {
                    decimal x = a.Days + 1;
                    decimal y = Decimal.Parse(lbCost.Text) * x;
                    bllBUS = new BillBUS();
                    BillDTO bll = new BillDTO();
                    bll.IDB = DateTime.Now.ToString();
                    bll.IDC = txtBoxCustomerName.Text;
                    bll.IDR = lbNameRoom.Text;
                    bll.CheckIn = DateTime.Parse(dtCheckIn.Text);
                    bll.CheckOut = DateTime.Parse(dtCheckOut.Text);
                    bll.COST = Decimal.Parse(lbCost.Text) * x;
                    bool kq = bllBUS.add(bll);

                    if (kq == false)
                        MessageBox.Show("Fail!");
                    else
                    {
                        rmBUS = new RoomBUS();
                        RoomDTO rm = new RoomDTO();
                        rm.Idr = lbNameRoom.Text;
                        rm.Status = "Có Khách";
                        bool kq1 = rmBUS.editStatus(rm);
                        if (kq == false)
                            MessageBox.Show("Fail!");
                        else
                            MessageBox.Show("Sussces");
                    }
                    isExsit = false;
                    nameCheck = false;
                    this.Close();
                }
            }
            
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if(numrow > -1)
            {
                txtBoxCustomerName.Text = dtgvCustomer.Rows[numrow].Cells[0].Value.ToString();
                txtBoxCustomerID.Text = dtgvCustomer.Rows[numrow].Cells[1].Value.ToString();
                txtBoxCustomerPhone.Text = dtgvCustomer.Rows[numrow].Cells[2].Value.ToString();
                isExsit = true;
            }    
            
        }

        private void CheckInWindow_Load(object sender, EventArgs e)
        {
            this.loadData();
            dtCheckIn.Value.ToString("dd-MM-yyyy");
            dtCheckIn.Text = DateTime.Now.ToString();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchCustomer.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<CustomerDTO> listTimKiem = ctmBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<CustomerDTO> listTimKiem = ctmBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void btLoadCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchCustomer.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<CustomerDTO> listTimKiem = ctmBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<CustomerDTO> listTimKiem = ctmBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }
        #endregion
    }
}
