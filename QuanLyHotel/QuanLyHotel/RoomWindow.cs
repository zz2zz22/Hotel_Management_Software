using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roomBUS;
using roomDAO;
using roomDTO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace QuanLyHotel
{
    public partial class RoomWindow : UserControl
    {
        public RoomWindow()
        {
            InitializeComponent();
            //this.loadData();
            btLoadRoom.Hide();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool checkCamera = false;
        string nameR = "";
        private RoomBUS rmBus;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            rmBus = new RoomBUS();
            List<RoomDTO> list = rmBus.select();
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvRoom.Columns.Clear();
            dtgvRoom.DataSource = null;

            dtgvRoom.AutoGenerateColumns = false;
            dtgvRoom.AllowUserToAddRows = false;
            dtgvRoom.DataSource = list;


            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "name";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "name";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(nAME);

            DataGridViewTextBoxColumn gENDER = new DataGridViewTextBoxColumn();
            gENDER.Name = "status";
            gENDER.HeaderText = "Status";
            gENDER.DataPropertyName = "status";
            gENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(gENDER);

            DataGridViewTextBoxColumn eMAIL = new DataGridViewTextBoxColumn();
            eMAIL.Name = "bedamount";
            eMAIL.HeaderText = "Bed Amount";
            eMAIL.DataPropertyName = "bedamount";
            eMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(eMAIL);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "roomkind";
            pHONE.HeaderText = "Room Kind";
            pHONE.DataPropertyName = "roomkind";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(pHONE);

            DataGridViewTextBoxColumn cOST = new DataGridViewTextBoxColumn();
            cOST.Name = "cost";
            cOST.HeaderText = "Cost";
            cOST.DataPropertyName = "cost";
            cOST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(cOST);
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvRoom.DataSource];
            myCurrencyManager.Refresh();
        }
        private void loadData(List<RoomDTO> list)
        {
            
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvRoom.Columns.Clear();
            dtgvRoom.DataSource = null;

            dtgvRoom.AutoGenerateColumns = false;
            dtgvRoom.AllowUserToAddRows = false;
            dtgvRoom.DataSource = list;


            DataGridViewTextBoxColumn nAME = new DataGridViewTextBoxColumn();
            nAME.Name = "name";
            nAME.HeaderText = "Name:";
            nAME.DataPropertyName = "name";
            nAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(nAME);

            DataGridViewTextBoxColumn gENDER = new DataGridViewTextBoxColumn();
            gENDER.Name = "status";
            gENDER.HeaderText = "Status";
            gENDER.DataPropertyName = "status";
            gENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(gENDER);

            DataGridViewTextBoxColumn eMAIL = new DataGridViewTextBoxColumn();
            eMAIL.Name = "bedamount";
            eMAIL.HeaderText = "Bed Amount";
            eMAIL.DataPropertyName = "bedamount";
            eMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(eMAIL);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "roomkind";
            pHONE.HeaderText = "Room Kind";
            pHONE.DataPropertyName = "roomkind";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(pHONE);

            DataGridViewTextBoxColumn cOST = new DataGridViewTextBoxColumn();
            cOST.Name = "cost";
            cOST.HeaderText = "Cost";
            cOST.DataPropertyName = "cost";
            cOST.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvRoom.Columns.Add(cOST);
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvRoom.DataSource];
            myCurrencyManager.Refresh();
        }
        #endregion
        //
        //---- EVENTS
        //
        #region Events
        private void dtgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if(numrow > -1)
            {
                txtNameRoom.Text = dtgvRoom.Rows[numrow].Cells[0].Value.ToString();
                txtKindRoom.Text = dtgvRoom.Rows[numrow].Cells[3].Value.ToString();
                txtBedsAmount.Text = dtgvRoom.Rows[numrow].Cells[2].Value.ToString();
                txtCost.Text = Convert.ToString(dtgvRoom.Rows[numrow].Cells[4].Value);
                nameR = txtNameRoom.Text;
                if (File.Exists("rm-" + nameR + ".bmp"))
                {
                    openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                    pictureBox1.Image = new Bitmap("rm-" + nameR + ".bmp");
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }    
            
        }

        private void TxtBedsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider5.SetError(txtBedsAmount, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider6.SetError(txtBedsAmount, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void btLoadRoom_Click(object sender, EventArgs e)
        {
            if (txtSearchRoom.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchRoom.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<RoomDTO> listTimKiem = rmBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<RoomDTO> listTimKiem = rmBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void btAddRoom_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            if (txtNameRoom.Text == "")
            {
                errorProvider1.SetError(txtNameRoom, "not null!");
            }
            else if (txtKindRoom.Text == "")
            {
                errorProvider2.SetError(txtKindRoom, "not null!");
            }
            else if (txtBedsAmount.Text == "")
            {
                errorProvider3.SetError(txtBedsAmount, "not null!");
            }
            else if (txtCost.Text == "")
            {
                errorProvider4.SetError(txtCost, "not null!");
            }

            else
            {
                rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.Idr = txtNameRoom.Text;
                rm.Name = txtNameRoom.Text;
                rm.Roomkind = txtKindRoom.Text;
                rm.Status = "Trống";
                rm.Bedamount = int.Parse(txtBedsAmount.Text);
                rm.Cost = Decimal.Parse(txtCost.Text);
                bool kq = rmBus.add(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void btEditRoom_Click_1(object sender, EventArgs e)
        {
            //Thêm errorProvider vào Edit
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            if (txtNameRoom.Text == "")
            {
                errorProvider1.SetError(txtNameRoom, "not null!");
            }
            else if (txtKindRoom.Text == "")
            {
                errorProvider2.SetError(txtKindRoom, "not null!");
            }
            else if (txtBedsAmount.Text == "")
            {
                errorProvider3.SetError(txtBedsAmount, "not null!");
            }
            else if (txtCost.Text == "")
            {
                errorProvider4.SetError(txtCost, "not null!");
            }

            else
            {
                rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.Idr = txtNameRoom.Text;
                rm.Name = txtNameRoom.Text;
                rm.Roomkind = txtKindRoom.Text;
                rm.Status = "Trống";
                rm.Bedamount = int.Parse(txtBedsAmount.Text);
                rm.Cost = Decimal.Parse(txtCost.Text);
                bool kq = rmBus.edit(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }

        private void btDeleteRoom_Click_1(object sender, EventArgs e)
        {
            //Thêm errorProvider vào delete
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();

            if (txtNameRoom.Text == "")
            {
                errorProvider1.SetError(txtNameRoom, "not null!");
            }
            else if (txtKindRoom.Text == "")
            {
                errorProvider2.SetError(txtKindRoom, "not null!");
            }
            else if (txtBedsAmount.Text == "")
            {
                errorProvider3.SetError(txtBedsAmount, "not null!");
            }
            else if (txtCost.Text == "")
            {
                errorProvider4.SetError(txtCost, "not null!");
            }

            else
            {
                rmBus = new RoomBUS();
                RoomDTO rm = new RoomDTO();
                rm.Idr = txtNameRoom.Text;
                rm.Name = txtNameRoom.Text;
                rm.Roomkind = txtKindRoom.Text;
                rm.Status = "Trống";
                rm.Bedamount = int.Parse(txtBedsAmount.Text);
                rm.Cost = Decimal.Parse(txtCost.Text);
                bool kq = rmBus.delete(rm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
        }
        #endregion

        private void btLoadRoom1_Click(object sender, EventArgs e)
        {
            if (txtSearchRoom.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchRoom.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<RoomDTO> listTimKiem = rmBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<RoomDTO> listTimKiem = rmBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void RoomWindow_Load(object sender, EventArgs e)
        {
            this.loadData();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchRoom.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchRoom.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<RoomDTO> listTimKiem = rmBus.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<RoomDTO> listTimKiem = rmBus.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (checkCamera == false)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                btnCapture.Text = "Stop";
                checkCamera = true;
            }
            else
            {
                checkCamera = false;
                videoCaptureDevice.Stop();
                btnCapture.Text = "Start";
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                nameR = txtNameRoom.Text;
            }
            //pictureBox1.Image = new Bitmap("rm-" + nameR + ".bmp");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("rm-" + nameR + ".bmp");
        }
    }
}
