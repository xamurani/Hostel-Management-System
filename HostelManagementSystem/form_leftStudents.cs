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
    public partial class form_leftStudents : Form
    {
        form_main fm;
        public form_leftStudents(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.leftStudents_menu.Enabled = false;
        }

        private void bt_closeLeftStudents_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.leftStudents_menu.Enabled = true;
        }
    }
}
