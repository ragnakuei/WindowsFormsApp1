using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = GenerateDataTable();

            dgv.CustomDataSource = dt;
        }

        private static DataTable GenerateDataTable()
        {
            var data = new DataTable();

            data.Columns.Add("Id", typeof(int));
            data.Columns.Add("Name", typeof(string));
            
            var row = data.NewRow();
            row[0] = 1;
            row[1] = "A";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = 2;
            row[1] = "B";
            data.Rows.Add(row);

            row = data.NewRow();
            row[0] = 3;
            row[1] = "C";
            data.Rows.Add(row);

            return data;
        }
    }
}
