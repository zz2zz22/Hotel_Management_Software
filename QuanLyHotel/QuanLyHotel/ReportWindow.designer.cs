namespace QuanLyHotel
{
    partial class ReportWindows
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
            this.btLoadService = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoadService
            // 
            this.btLoadService.BackColor = System.Drawing.Color.Firebrick;
            this.btLoadService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoadService.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadService.ForeColor = System.Drawing.Color.White;
            this.btLoadService.Location = new System.Drawing.Point(31, 88);
            this.btLoadService.Margin = new System.Windows.Forms.Padding(4);
            this.btLoadService.Name = "btLoadService";
            this.btLoadService.Size = new System.Drawing.Size(99, 38);
            this.btLoadService.TabIndex = 225;
            this.btLoadService.Text = "Load";
            this.btLoadService.UseVisualStyleBackColor = false;
            this.btLoadService.Click += new System.EventHandler(this.btLoadService_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(19, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 38);
            this.label16.TabIndex = 214;
            this.label16.Text = "Report";
            // 
            // dtgvService
            // 
            this.dtgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Kind,
            this.Date,
            this.Cost,
            this.Note});
            this.dtgvService.Location = new System.Drawing.Point(31, 134);
            this.dtgvService.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.ReadOnly = true;
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.Size = new System.Drawing.Size(954, 544);
            this.dtgvService.TabIndex = 213;
            // 
            // Names
            // 
            this.Names.HeaderText = "Name";
            this.Names.MinimumWidth = 6;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            // 
            // Kind
            // 
            this.Kind.HeaderText = "Kind";
            this.Kind.MinimumWidth = 6;
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSumCost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServiceCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExpense);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(995, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 374);
            this.groupBox1.TabIndex = 227;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total income";
            // 
            // txtRoomCost
            // 
            this.txtRoomCost.Location = new System.Drawing.Point(120, 169);
            this.txtRoomCost.Name = "txtRoomCost";
            this.txtRoomCost.ReadOnly = true;
            this.txtRoomCost.Size = new System.Drawing.Size(138, 22);
            this.txtRoomCost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room";
            // 
            // txtSumCost
            // 
            this.txtSumCost.Location = new System.Drawing.Point(120, 271);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.ReadOnly = true;
            this.txtSumCost.Size = new System.Drawing.Size(138, 22);
            this.txtSumCost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(120, 107);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.ReadOnly = true;
            this.txtServiceCost.Size = new System.Drawing.Size(138, 22);
            this.txtServiceCost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service";
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(120, 43);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.ReadOnly = true;
            this.txtExpense.Size = new System.Drawing.Size(138, 22);
            this.txtExpense.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expense";
            // 
            // ReportWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLoadService);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtgvService);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportWindows";
            this.Size = new System.Drawing.Size(1283, 682);
            this.Load += new System.EventHandler(this.ReportWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLoadService;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoomCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label2;
    }
}
