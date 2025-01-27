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
    public partial class AddNewRoom : Form
    {
        form_main fm;
        DataSet ds = new DataSet();
        databaseConnection db = new databaseConnection();
        public AddNewRoom(form_main fm1)
        {
            InitializeComponent();
            fm = fm1;
            RoomManagementDataDridViewUpdate();
        }
        public void RoomManagementDataDridViewUpdate()
        {
            ds = db.sqlreader("select * from RoomManagement");
            RoomManagement_dataGridView.DataSource = ds.Tables[0];
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.menu_manageRooms.Enabled = true;
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            db.sqlwritter("INSERT INTO RoomManagement (RoomNumber,Capacity,TotalReserved,fees,BulidingNumber,Floor) VALUES ('" + tb_roomNumber.Text + "', '" + tb_capacity.Text + "', '" + tb_totalReservation.Text + "', " + tb_fees.Text + ", '" + tb_BulidingNumber.Text + "', '" + tb_floor.Text + "')");
            MessageBox.Show("A Room has been managed successfully!","Room Management message");
            RoomManagementDataDridViewUpdate();
            tb_floor.Text = "";
            tb_roomNumber.Text = "";
            tb_totalReservation.Text = "";
            tb_fees.Text = "";
            tb_capacity.Text = "";
            tb_BulidingNumber.Text = "";
        }

        private void RoomManagement_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Ri.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_c.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_TR.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_F.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_BN.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_fl.Text = RoomManagement_dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
