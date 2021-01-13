namespace QuanLyHotel
{
    partial class AccountWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btLoadAccount = new System.Windows.Forms.Button();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btDeleteAcount = new System.Windows.Forms.Button();
            this.btEditAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.TextBox();
            this.lbCmnd = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoadAccount
            // 
            this.btLoadAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLoadAccount.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadAccount.ForeColor = System.Drawing.Color.White;
            this.btLoadAccount.Location = new System.Drawing.Point(729, 563);
            this.btLoadAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadAccount.MaximumSize = new System.Drawing.Size(99, 38);
            this.btLoadAccount.Name = "btLoadAccount";
            this.btLoadAccount.Size = new System.Drawing.Size(99, 38);
            this.btLoadAccount.TabIndex = 198;
            this.btLoadAccount.Text = "Load";
            this.btLoadAccount.UseVisualStyleBackColor = false;
            this.btLoadAccount.Click += new System.EventHandler(this.BtLoadAccount_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Location = new System.Drawing.Point(115, 563);
            this.txtSearchAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchAccount.MaxLength = 40;
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(605, 35);
            this.txtSearchAccount.TabIndex = 197;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(17, 607);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.Size = new System.Drawing.Size(1245, 372);
            this.dtgvAccount.TabIndex = 196;
            this.dtgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAccount_CellClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 567);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 195;
            this.label5.Text = "Search";
            // 
            // btDeleteAcount
            // 
            this.btDeleteAcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteAcount.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteAcount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteAcount.ForeColor = System.Drawing.Color.White;
            this.btDeleteAcount.Location = new System.Drawing.Point(149, 468);
            this.btDeleteAcount.Margin = new System.Windows.Forms.Padding(4);
            this.btDeleteAcount.Name = "btDeleteAcount";
            this.btDeleteAcount.Size = new System.Drawing.Size(99, 38);
            this.btDeleteAcount.TabIndex = 203;
            this.btDeleteAcount.Text = "Delete";
            this.btDeleteAcount.UseVisualStyleBackColor = false;
            this.btDeleteAcount.Click += new System.EventHandler(this.BtDeleteAcount_Click);
            // 
            // btEditAccount
            // 
            this.btEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEditAccount.BackColor = System.Drawing.Color.Firebrick;
            this.btEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditAccount.ForeColor = System.Drawing.Color.White;
            this.btEditAccount.Location = new System.Drawing.Point(26, 468);
            this.btEditAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btEditAccount.Name = "btEditAccount";
            this.btEditAccount.Size = new System.Drawing.Size(99, 38);
            this.btEditAccount.TabIndex = 202;
            this.btEditAccount.Text = "Edit";
            this.btEditAccount.UseVisualStyleBackColor = false;
            this.btEditAccount.Click += new System.EventHandler(this.BtEditAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 38);
            this.label3.TabIndex = 199;
            this.label3.Text = "Account Information";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(22, 194);
            this.label.Margin = new System.Windows.Forms.Padding(4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 26);
            this.label.TabIndex = 212;
            this.label.Text = "Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(22, 234);
            this.label18.Margin = new System.Windows.Forms.Padding(4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 26);
            this.label18.TabIndex = 204;
            this.label18.Text = "Gender:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(22, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 26);
            this.label15.TabIndex = 205;
            this.label15.Text = "Identify card:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 206;
            this.label1.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 207;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 216;
            this.label4.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(22, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 26);
            this.label7.TabIndex = 214;
            this.label7.Text = "Password:";
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(188, 115);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.ReadOnly = true;
            this.lbUsername.Size = new System.Drawing.Size(322, 30);
            this.lbUsername.TabIndex = 218;
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(188, 151);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(322, 30);
            this.lbPassword.TabIndex = 219;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(188, 191);
            this.lbName.Name = "lbName";
            this.lbName.ReadOnly = true;
            this.lbName.Size = new System.Drawing.Size(322, 30);
            this.lbName.TabIndex = 220;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(188, 270);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(322, 30);
            this.lbPhone.TabIndex = 222;
            this.lbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbPhone_KeyPress);
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(188, 311);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(322, 30);
            this.lbEmail.TabIndex = 223;
            // 
            // lbCmnd
            // 
            this.lbCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCmnd.Location = new System.Drawing.Point(188, 351);
            this.lbCmnd.Name = "lbCmnd";
            this.lbCmnd.Size = new System.Drawing.Size(322, 30);
            this.lbCmnd.TabIndex = 224;
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.FormattingEnabled = true;
            this.lbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.lbGender.Location = new System.Drawing.Point(188, 231);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(322, 33);
            this.lbGender.TabIndex = 225;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 226;
            this.label6.Text = "Level:";
            // 
            // lbLevel
            // 
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(188, 391);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(322, 30);
            this.lbLevel.TabIndex = 227;
            this.lbLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbLevel_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // AccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbCmnd);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDeleteAcount);
            this.Controls.Add(this.btEditAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLoadAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountWindow";
            this.Size = new System.Drawing.Size(1283, 999);
            this.Load += new System.EventHandler(this.AccountWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoadAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDeleteAcount;
        private System.Windows.Forms.Button btEditAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lbUsername;
        private System.Windows.Forms.TextBox lbPassword;
        private System.Windows.Forms.TextBox lbName;
        private System.Windows.Forms.TextBox lbPhone;
        private System.Windows.Forms.TextBox lbEmail;
        private System.Windows.Forms.TextBox lbCmnd;
        private System.Windows.Forms.ComboBox lbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lbLevel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}
