﻿namespace QuanLyHotel
{
    partial class RoomWindow
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.txtNameRoom = new System.Windows.Forms.TextBox();
            this.txtKindRoom = new System.Windows.Forms.ComboBox();
            this.txtBedsAmount = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btAddRoom = new System.Windows.Forms.Button();
            this.btEditRoom = new System.Windows.Forms.Button();
            this.btDeleteRoom = new System.Windows.Forms.Button();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.btLoadRoom = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSumRoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 136;
            this.label5.Text = "Search";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 135;
            this.label3.Text = "Room Information";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 152;
            this.label2.Text = "Beds Amount";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 147;
            this.label4.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 145;
            this.label6.Text = "Kind";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 22);
            this.label7.TabIndex = 146;
            this.label7.Text = "Cost";
            // 
            // dtgvRoom
            // 
            this.dtgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Location = new System.Drawing.Point(17, 301);
            this.dtgvRoom.Name = "dtgvRoom";
            this.dtgvRoom.RowHeadersWidth = 51;
            this.dtgvRoom.Size = new System.Drawing.Size(1239, 274);
            this.dtgvRoom.TabIndex = 154;
            this.dtgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRoom_CellClick);
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRoom.Location = new System.Drawing.Point(134, 41);
            this.txtNameRoom.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtNameRoom.MaxLength = 40;
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(450, 29);
            this.txtNameRoom.TabIndex = 186;
            // 
            // txtKindRoom
            // 
            this.txtKindRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKindRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtKindRoom.FormattingEnabled = true;
            this.txtKindRoom.Items.AddRange(new object[] {
            "Vip",
            "Thường"});
            this.txtKindRoom.Location = new System.Drawing.Point(134, 76);
            this.txtKindRoom.MaximumSize = new System.Drawing.Size(450, 0);
            this.txtKindRoom.MaxLength = 40;
            this.txtKindRoom.Name = "txtKindRoom";
            this.txtKindRoom.Size = new System.Drawing.Size(450, 30);
            this.txtKindRoom.TabIndex = 187;
            // 
            // txtBedsAmount
            // 
            this.txtBedsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBedsAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedsAmount.Location = new System.Drawing.Point(134, 115);
            this.txtBedsAmount.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtBedsAmount.MaxLength = 40;
            this.txtBedsAmount.Name = "txtBedsAmount";
            this.txtBedsAmount.Size = new System.Drawing.Size(450, 29);
            this.txtBedsAmount.TabIndex = 188;
            this.txtBedsAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBedsAmount_KeyPress);
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(134, 150);
            this.txtCost.MaximumSize = new System.Drawing.Size(450, 29);
            this.txtCost.MaxLength = 40;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(450, 29);
            this.txtCost.TabIndex = 189;
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCost_KeyPress);
            // 
            // btAddRoom
            // 
            this.btAddRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAddRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddRoom.ForeColor = System.Drawing.Color.White;
            this.btAddRoom.Location = new System.Drawing.Point(71, 215);
            this.btAddRoom.Name = "btAddRoom";
            this.btAddRoom.Size = new System.Drawing.Size(74, 31);
            this.btAddRoom.TabIndex = 190;
            this.btAddRoom.Text = "Add";
            this.btAddRoom.UseVisualStyleBackColor = false;
            this.btAddRoom.Click += new System.EventHandler(this.btAddRoom_Click_1);
            // 
            // btEditRoom
            // 
            this.btEditRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btEditRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditRoom.ForeColor = System.Drawing.Color.White;
            this.btEditRoom.Location = new System.Drawing.Point(161, 215);
            this.btEditRoom.Name = "btEditRoom";
            this.btEditRoom.Size = new System.Drawing.Size(74, 31);
            this.btEditRoom.TabIndex = 191;
            this.btEditRoom.Text = "Edit";
            this.btEditRoom.UseVisualStyleBackColor = false;
            this.btEditRoom.Click += new System.EventHandler(this.btEditRoom_Click_1);
            // 
            // btDeleteRoom
            // 
            this.btDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btDeleteRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btDeleteRoom.Location = new System.Drawing.Point(253, 215);
            this.btDeleteRoom.Name = "btDeleteRoom";
            this.btDeleteRoom.Size = new System.Drawing.Size(74, 31);
            this.btDeleteRoom.TabIndex = 192;
            this.btDeleteRoom.Text = "Delete";
            this.btDeleteRoom.UseVisualStyleBackColor = false;
            this.btDeleteRoom.Click += new System.EventHandler(this.btDeleteRoom_Click_1);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoom.Location = new System.Drawing.Point(86, 265);
            this.txtSearchRoom.MaxLength = 40;
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(719, 29);
            this.txtSearchRoom.TabIndex = 193;
            // 
            // btLoadRoom
            // 
            this.btLoadRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLoadRoom.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadRoom.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadRoom.ForeColor = System.Drawing.Color.White;
            this.btLoadRoom.Location = new System.Drawing.Point(810, 264);
            this.btLoadRoom.Name = "btLoadRoom";
            this.btLoadRoom.Size = new System.Drawing.Size(74, 31);
            this.btLoadRoom.TabIndex = 194;
            this.btLoadRoom.Text = "Load";
            this.btLoadRoom.UseVisualStyleBackColor = false;
            this.btLoadRoom.Click += new System.EventHandler(this.btLoadRoom_Click);
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
            // txtSumRoom
            // 
            this.txtSumRoom.Location = new System.Drawing.Point(758, 226);
            this.txtSumRoom.Name = "txtSumRoom";
            this.txtSumRoom.Size = new System.Drawing.Size(100, 20);
            this.txtSumRoom.TabIndex = 216;
            // 
            // RoomWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSumRoom);
            this.Controls.Add(this.btLoadRoom);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.btDeleteRoom);
            this.Controls.Add(this.btEditRoom);
            this.Controls.Add(this.btAddRoom);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtBedsAmount);
            this.Controls.Add(this.txtKindRoom);
            this.Controls.Add(this.txtNameRoom);
            this.Controls.Add(this.dtgvRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "RoomWindow";
            this.Size = new System.Drawing.Size(1273, 587);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvRoom;
        private System.Windows.Forms.TextBox txtNameRoom;
        private System.Windows.Forms.ComboBox txtKindRoom;
        private System.Windows.Forms.TextBox txtBedsAmount;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btAddRoom;
        private System.Windows.Forms.Button btEditRoom;
        private System.Windows.Forms.Button btDeleteRoom;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.Button btLoadRoom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.TextBox txtSumRoom;
    }
}
