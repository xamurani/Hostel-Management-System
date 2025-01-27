using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class form_allStudents : Form
    {
        DataSet ds = new DataSet();
        form_main fm;
        public form_allStudents(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.allStudents_menu.Enabled = false;
        }

        private void bt_closeAllStudents_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.allStudents_menu.Enabled = true;
        }
    }
}
