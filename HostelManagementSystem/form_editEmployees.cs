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
    public partial class form_editEmployees : Form
    {
        form_main fm;
        public form_editEmployees(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.editEmployee_menu.Enabled = false;
        }

        private void bt_closeEditemployees_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.editEmployee_menu.Enabled = true;
        }
    }
}
