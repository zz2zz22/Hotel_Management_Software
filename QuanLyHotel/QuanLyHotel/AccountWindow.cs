using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBUS;
using userDTO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace QuanLyHotel
{
    public partial class AccountWindow : UserControl
    {
        public AccountWindow()
        {
            InitializeComponent();
            //loadData();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool checkCamera = false;
        string nameMNG = "";
        private UserBUS userBUS;

        //
        //---- LOAD DATA
        //
        #region Load Data
        private void loadData()
        {
            userBUS = new UserBUS();
            List<UserDTO> list = userBUS.select();

            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvAccount.Columns.Clear();
            dtgvAccount.DataSource = null;

            dtgvAccount.AutoGenerateColumns = false;
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.DataSource = list;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "idm";
            ID.HeaderText = "Username";
            ID.DataPropertyName = "idm";
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(ID);

            DataGridViewTextBoxColumn PassWord = new DataGridViewTextBoxColumn();
            PassWord.Name = "pasword";
            PassWord.HeaderText = "PassWord";
            PassWord.DataPropertyName = "password";
            PassWord.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(PassWord);

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(NAME);

            DataGridViewTextBoxColumn Gender = new DataGridViewTextBoxColumn();
            Gender.Name = "gender";
            Gender.HeaderText = "Gender";
            Gender.DataPropertyName = "gender";
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Gender);

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "PHONE";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(pHONE);

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.Name = "email";
            Email.HeaderText = "Email";
            Email.DataPropertyName = "email";
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Email);

            DataGridViewTextBoxColumn Level = new DataGridViewTextBoxColumn();
            Level.Name = "level";
            Level.HeaderText = "Level";
            Level.DataPropertyName = "level";
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Level);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvAccount.DataSource];
            myCurrencyManager.Refresh();


        }
        private void loadData(List<UserDTO> list)
        {
            if (list == null)
            {
                MessageBox.Show("Fail");
                return;
            }
            dtgvAccount.Columns.Clear();
            dtgvAccount.DataSource = null;

            dtgvAccount.AutoGenerateColumns = false;
            dtgvAccount.AllowUserToAddRows = false;
            dtgvAccount.DataSource = list;

            DataGridViewTextBoxColumn ID = new DataGridViewTextBoxColumn();
            ID.Name = "idm";
            ID.HeaderText = "Username";
            ID.DataPropertyName = "idm";
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(ID);

            DataGridViewTextBoxColumn PassWord = new DataGridViewTextBoxColumn();
            PassWord.Name = "pasword";
            PassWord.HeaderText = "PassWord";
            PassWord.DataPropertyName = "password";
            PassWord.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(PassWord);

            DataGridViewTextBoxColumn NAME = new DataGridViewTextBoxColumn();
            NAME.Name = "name";
            NAME.HeaderText = "Name:";
            NAME.DataPropertyName = "name";
            NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(NAME);

            DataGridViewTextBoxColumn Gender = new DataGridViewTextBoxColumn();
            Gender.Name = "gender";
            Gender.HeaderText = "Gender";
            Gender.DataPropertyName = "gender";
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Gender);

            DataGridViewTextBoxColumn CMND = new DataGridViewTextBoxColumn();
            CMND.Name = "cmnd";
            CMND.HeaderText = "Identify card";
            CMND.DataPropertyName = "cmnd";
            CMND.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(CMND);

            DataGridViewTextBoxColumn pHONE = new DataGridViewTextBoxColumn();
            pHONE.Name = "phone";
            pHONE.HeaderText = "PHONE";
            pHONE.DataPropertyName = "phone";
            pHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(pHONE);

            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            Email.Name = "email";
            Email.HeaderText = "Email";
            Email.DataPropertyName = "email";
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Email);

            DataGridViewTextBoxColumn Level = new DataGridViewTextBoxColumn();
            Level.Name = "level";
            Level.HeaderText = "Level";
            Level.DataPropertyName = "level";
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvAccount.Columns.Add(Level);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvAccount.DataSource];
            myCurrencyManager.Refresh();


        }
        #endregion
        //
        //---- EVENT : BTN OR CELL CLICK
        //
        #region Events
        private void BtLoadAccount_Click(object sender, EventArgs e)
        {
            if (txtSearchAccount.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchAccount.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<UserDTO> listTimKiem = userBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<UserDTO> listTimKiem = userBUS.search(Key);
                    this.loadData(listTimKiem);
                }
            }
        }
        private void BtEditAccount_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            if (lbPassword.Text == "")
            {
                errorProvider1.SetError(lbPassword, "not null!");

            }
            else if (lbGender.Text == "")
            {
                errorProvider2.SetError(lbGender, "not null!");
            }
            else if(lbPhone.Text == "")
            {
                errorProvider3.SetError(lbPhone, "not null!");
            }
            else if(lbEmail.Text == "")
            {
                errorProvider4.SetError(lbEmail, "not null!");

            }
            else if(lbCmnd.Text == "")
            {
                errorProvider5.SetError(lbCmnd, "not null!");
            }
            else if(lbLevel.Text == "")
            {

                errorProvider6.SetError(lbLevel, "not null!");
            }
            else
            {
                userBUS = new UserBUS();
                UserDTO ctm = new UserDTO();
                ctm.Idm = lbUsername.Text;
                ctm.Password = lbPassword.Text;
                ctm.Name = lbName.Text;
                ctm.Phone = lbPhone.Text;
                ctm.Email = lbEmail.Text;
                ctm.Cmnd = lbCmnd.Text;
                ctm.Level = Convert.ToInt32(lbLevel.Text);
                ctm.Gender = lbGender.Text;
                bool kq = userBUS.edit(ctm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
                //Us.Idm = txtUsername.Text;
                //Us.Name = txtName.Text;
                //Us.Password = txtPassword.Text;
                //Us.Phone = txtPhone.Text;
                //Us.Email = txtEmail.Text;
                //Us.Gender = txtGender.Text;
                //Us.Cmnd = txtIdentifyCard.Text;
                //Us.Level = 1;
                //bool kq = UsBus.add(Us);
            }    
            
        }
        private void BtDeleteAcount_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            if (lbPassword.Text == "")
            {
                errorProvider1.SetError(lbPassword, "not null!");

            }
            else if (lbGender.Text == "")
            {
                errorProvider2.SetError(lbGender, "not null!");
            }
            else if (lbPhone.Text == "")
            {
                errorProvider3.SetError(lbPhone, "not null!");
            }
            else if (lbEmail.Text == "")
            {
                errorProvider4.SetError(lbEmail, "not null!");

            }
            else if (lbCmnd.Text == "")
            {
                errorProvider5.SetError(lbCmnd, "not null!");
            }
            else if (lbLevel.Text == "")
            {

                errorProvider6.SetError(lbLevel, "not null!");
            }
            else
            {
                userBUS = new UserBUS();
                UserDTO ctm = new UserDTO();
                ctm.Idm = lbUsername.Text;
                ctm.Password = lbPassword.Text;
                ctm.Name = lbName.Text;
                ctm.Phone = lbPhone.Text;
                ctm.Email = lbEmail.Text;
                ctm.Cmnd = lbCmnd.Text;
                ctm.Level = Convert.ToInt32(lbLevel.Text);
                ctm.Gender = lbGender.Text;
                bool kq = userBUS.delete(ctm);
                if (kq == false)
                    MessageBox.Show("Fail!");
                else
                    MessageBox.Show("Sussces");
                this.loadData();
            }
            
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if(numrow>-1)
            {
                lbUsername.Text = dtgvAccount.Rows[numrow].Cells[0].Value.ToString();
                lbPassword.Text = dtgvAccount.Rows[numrow].Cells[1].Value.ToString();
                lbName.Text = dtgvAccount.Rows[numrow].Cells[2].Value.ToString();
                lbGender.Text = dtgvAccount.Rows[numrow].Cells[3].Value.ToString();
                lbEmail.Text = dtgvAccount.Rows[numrow].Cells[6].Value.ToString();
                lbPhone.Text = dtgvAccount.Rows[numrow].Cells[5].Value.ToString();
                lbCmnd.Text = dtgvAccount.Rows[numrow].Cells[4].Value.ToString();
                lbLevel.Text = dtgvAccount.Rows[numrow].Cells[7].Value.ToString();

                nameMNG = lbUsername.Text;
                if (File.Exists("ac-" + nameMNG + ".bmp"))
                {
                    openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                    pictureBox1.Image = new Bitmap("ac-" + nameMNG + ".bmp");
                }
                else
                {
                    pictureBox1.Image = null;
                }
                    
                
            }    
            
        }
        #endregion

        private void lbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider3.SetError(lbPhone, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void lbLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keydown = e.KeyChar;
            if (keydown > 57 || (keydown < 48 && keydown > 9 && keydown < 7))
            {
                errorProvider6.SetError(lbLevel, "Không được nhập chữ");
                e.KeyChar = (char)0;
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void AccountWindow_Load(object sender, EventArgs e)
        {
            this.loadData();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchAccount.Text == "")
            {
                this.loadData();
            }
            else
            {
                string Key = txtSearchAccount.Text.Trim();
                if (Key == null || Key == string.Empty || Key.Length == 0)
                {
                    List<UserDTO> listTimKiem = userBUS.select();
                    this.loadData(listTimKiem);
                }
                else
                {
                    List<UserDTO> listTimKiem = userBUS.search(Key);
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
                nameMNG = lbName.Text;
            }
            //pictureBox1.Image = new Bitmap("ac-" + nameMNG + ".bmp");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("ac-" + nameMNG + ".bmp");
        }
    }
}
