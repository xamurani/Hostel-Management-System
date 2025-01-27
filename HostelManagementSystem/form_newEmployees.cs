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
    public partial class form_newEmployees : Form
    {
        form_main fm;
        public form_newEmployees(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.newEmployee_menu.Enabled = false;
        }

        private void bt_closeNewEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.newEmployee_menu.Enabled = true;
        }
    }
}
