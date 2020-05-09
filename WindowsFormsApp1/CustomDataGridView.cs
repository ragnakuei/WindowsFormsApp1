using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CustomDataGridView : DataGridView
    {
        public object CustomDataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                base.DataSource = value;
            }
        }
    }
}
