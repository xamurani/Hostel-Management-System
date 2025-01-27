using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HostelManagementSystem
{
    public partial class form_admission : Form
    {
        form_main fm;
        public form_admission()
        {
            InitializeComponent();
        }
        public form_admission(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            fm.admission_menu.Enabled = false; ;
        }

        private void bt_closeAdmissionForm_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.admission_menu.Enabled = true;
        }

        private void bt_admit_Click(object sender, EventArgs e)
        {
            databaseConnection db = new databaseConnection();
            db.sqlwritter("INSERT INTO AdmissionForm (StudentName,FatherName,Nationality,DateOfBirth,NICno,PhoneNo,StateOrProvince,RoomNumber,Gender,BloodGroup,Adress,PicturePath) VALUES ('" + tb_name.Text + "', '" + tb_fatheName.Text + "', '" + tb_nationality.Text + "', '"+ tb_dateOfBirth.Text + "', '" + tb_nIC.Text + "', '"+ tb_phoneNo.Text +"', '"+ tb_stateOrProvince.Text +"', '"+ tb_RoomNumber.Text +"', '"+ tb_gender.Text +"','"+ tb_bloodGroup.Text +"','"+ tb_adress.Text +"','"+tb_picturePath.Text+"')");
            MessageBox.Show("A student is admitted successfully!");
            fm.admission_menu.Enabled = true;
            this.Close();
;        }

        private void bt_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                tb_picturePath.Text = open.FileName;
                pt_admission.Image = new Bitmap(open.FileName);
            }
        }
    }
}
