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
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            form_login fl = new form_login(this);
            fl.Show();
            fl.MdiParent = this;
            menu_employees.Enabled = false;
            menu_students.Enabled = false;
            menu_manageRooms.Enabled = false;
        }

        private void menu_manageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom anr = new AddNewRoom(this);
            anr.Show();
            anr.MdiParent = this;
            menu_manageRooms.Enabled = false;
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_admission fa = new form_admission(this);
            fa.MdiParent = this;
            fa.Show();
        }

        private void editStudent_menu_Click(object sender, EventArgs e)
        {
            form_studentEdit fse = new form_studentEdit(this);
            fse.Show();
            fse.MdiParent = this;
        }

        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_allStudents als = new form_allStudents(this);
            als.Show();
            als.MdiParent = this;
        }

        private void leftStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_leftStudents fl = new form_leftStudents(this);
            fl.Show();
            fl.MdiParent = this;
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_newEmployees fne = new form_newEmployees(this);
            fne.Show();
            fne.MdiParent = this;
        }

        private void editEmployee_menu_Click(object sender, EventArgs e)
        {
            form_editEmployees fee = new form_editEmployees(this);
            fee.Show();
            fee.MdiParent = this;
        }

        private void allEmployeesWorking_menu_Click(object sender, EventArgs e)
        {
            form_allEmployeesWorking few = new form_allEmployeesWorking(this);
            few.Show();
            few.MdiParent = this;
        }

        private void leftEmployees_Click(object sender, EventArgs e)
        {
            form_leftEmployees fle = new form_leftEmployees(this);
            fle.Show();
            fle.MdiParent = this;
        }
    }
}
