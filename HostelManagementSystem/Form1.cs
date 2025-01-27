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
    public partial class form_login : Form
    {
        form_main fm;
        public form_login(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
        }

        private void bt_signIn_Click(object sender, EventArgs e)
        {
            databaseConnection db = new databaseConnection();
            DataSet ds = db.sqlreader("select * from login where username = '" + tb_username.Text + "' and password = '" + tb_password.Text + "'");
            if (ds.Tables[0].Rows.Count >= 1)
            {
                this.Hide();
                fm.menu_students.Enabled = true;
                fm.menu_employees.Enabled = true;
                fm.menu_manageRooms.Enabled = true;
            }
            else
            {
                tb_password.Clear();
                //MessageBox.Show("Wrong username or password");
            }
        }
    }
}
