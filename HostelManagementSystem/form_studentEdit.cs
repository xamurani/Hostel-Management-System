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
    public partial class form_studentEdit : Form
    {
        DataSet ds = new DataSet();
        form_main fm;
        databaseConnection db = new databaseConnection();
        public form_studentEdit(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.editStudent_menu.Enabled = false;
            AdmissionFOrmDataDridViewUpdate();
        }
        public void AdmissionFOrmDataDridViewUpdate()
        {
            ds = db.sqlreader("select * from AdmissionForm");
            editStudent_datagridview.DataSource = ds.Tables[0];
        }

        private void bt_closeStudentEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.editStudent_menu.Enabled = true;
        }

        private void form_studentEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet1.admissionForm' table. You can move, or remove it, as needed.
            this.admissionFormTableAdapter.Fill(this.dataDataSet1.admissionForm);
            // TODO: This line of code loads data into the 'dataDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataDataSet.login);

        }

        private void editStudent_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_fatheName.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_nationality.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_dateOfBirth.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_nIC.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_phoneNo.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[6].Value.ToString();
            tb_stateOrProvince.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[7].Value.ToString();
            tb_bloodGroup.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[10].Value.ToString();
            tb_roonNumber.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[8].Value.ToString();
            tb_gender.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[9].Value.ToString();
            tb_adress.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[11].Value.ToString();
            tb_id.Text = Text = editStudent_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_picturePathStudentEdit.Text = editStudent_datagridview.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void bt_pictureStudentEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                tb_picturePathStudentEdit.Text = open.FileName;
                pt_StudentEdit.Image = new Bitmap(open.FileName);
            }
        }

        private void bt_UpdateStudentEdit_Click(object sender, EventArgs e)
        {
            db.sqlwritter("update AdmissionForm set StudentName = '" + tb_name.Text + "', FatherName = '" + tb_fatheName.Text + "', Nationality = '" + tb_nationality.Text + "', DateOfBirth = '" + tb_dateOfBirth.Text + "', NICno = '" + tb_nIC.Text + "', PhoneNo = '"+ tb_phoneNo.Text +"', StateOrProvince = '"+ tb_stateOrProvince.Text +"', BloodGroup = '"+ tb_bloodGroup.Text +"', Gender = '"+ tb_gender.Text +"', Adress = '"+ tb_adress.Text +"', PicturePath = '"+ tb_picturePathStudentEdit.Text +"' where ID = " + tb_id.Text + " ");
            MessageBox.Show("Updation is successful!", "Upation Information");
            AdmissionFOrmDataDridViewUpdate();
            this.Close();
            fm.editStudent_menu.Enabled = true;
        }

        private void bt_DeleteStudentEdit_Click(object sender, EventArgs e)
        {
            db.sqlwritter("delete from AdmissionForm where id = " + tb_id.Text + "");
            MessageBox.Show("A record has been successfully deleted!", "Delete message");
            AdmissionFOrmDataDridViewUpdate();
            this.Close();
            fm.editStudent_menu.Enabled = true;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            ds = db.sqlreader("select * from AdmissionForm where StudentName like '%"+tb_search.Text+"%' ");
            if (ds.Tables[0].Rows.Count >= 1)
            {
                editStudent_datagridview.DataSource = ds.Tables[0];
            }
            else
            {
                    AdmissionFOrmDataDridViewUpdate();
            }
        }
    }
}
