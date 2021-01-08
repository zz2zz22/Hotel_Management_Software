using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHotel
{
    public partial class ReportWindows : UserControl
    {
        public ReportWindows()
        {
            InitializeComponent();
        }
        private void btLoadService_Click(object sender, EventArgs e)
        {
            string filePath = @"file.txt";
            string[] lines;
            dtgvService.Rows.Clear();
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    dtgvService.Rows.Add(lines[i].Split());
                    
                }
            }
            else
            {

            }
            foreach(DataGridViewRow row in dtgvService.Rows)
            {
                double Expense_Cost = 0, Room_Cost = 0, Service_Cost = 0;
                if(row.Cells[1].Value.ToString() == "Expense")
                {
                    Expense_Cost += Double.Parse(row.Cells[3].Value.ToString());
                }
                if (row.Cells[1].Value.ToString() == "Room")
                {
                    Room_Cost += Double.Parse(row.Cells[3].Value.ToString());
                }
                if (row.Cells[1].Value.ToString() == "Service")
                {
                    Service_Cost += Double.Parse(row.Cells[3].Value.ToString());
                }
                txtExpense.Text = Expense_Cost.ToString();
                txtRoomCost.Text = Room_Cost.ToString();
                txtServiceCost.Text = Service_Cost.ToString();
                txtSumCost.Text = (Expense_Cost + Room_Cost + Service_Cost).ToString();
            }    
        }
    }
}
