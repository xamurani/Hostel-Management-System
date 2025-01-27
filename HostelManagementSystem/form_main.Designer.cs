namespace HostelManagementSystem
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_students = new System.Windows.Forms.ToolStripMenuItem();
            this.admission_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudent_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.feeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudents_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftStudents_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_employees = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployee_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployee_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.aEmployeePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeesWorking_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_manageRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_students,
            this.menu_employees,
            this.menu_manageRooms});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_students
            // 
            this.menu_students.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admission_menu,
            this.editStudent_menu,
            this.feeToolStripMenuItem,
            this.allStudents_menu,
            this.leftStudents_menu});
            this.menu_students.Enabled = false;
            this.menu_students.Name = "menu_students";
            this.menu_students.Size = new System.Drawing.Size(65, 20);
            this.menu_students.Text = "Students";
            // 
            // admission_menu
            // 
            this.admission_menu.Image = ((System.Drawing.Image)(resources.GetObject("admission_menu.Image")));
            this.admission_menu.Name = "admission_menu";
            this.admission_menu.Size = new System.Drawing.Size(161, 22);
            this.admission_menu.Text = "Admission Form";
            this.admission_menu.Click += new System.EventHandler(this.admissionToolStripMenuItem_Click);
            // 
            // editStudent_menu
            // 
            this.editStudent_menu.Image = ((System.Drawing.Image)(resources.GetObject("editStudent_menu.Image")));
            this.editStudent_menu.Name = "editStudent_menu";
            this.editStudent_menu.Size = new System.Drawing.Size(161, 22);
            this.editStudent_menu.Text = "Edit a student";
            this.editStudent_menu.Click += new System.EventHandler(this.editStudent_menu_Click);
            // 
            // feeToolStripMenuItem
            // 
            this.feeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feeToolStripMenuItem.Image")));
            this.feeToolStripMenuItem.Name = "feeToolStripMenuItem";
            this.feeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.feeToolStripMenuItem.Text = "Fee of a student";
            // 
            // allStudents_menu
            // 
            this.allStudents_menu.Image = ((System.Drawing.Image)(resources.GetObject("allStudents_menu.Image")));
            this.allStudents_menu.Name = "allStudents_menu";
            this.allStudents_menu.Size = new System.Drawing.Size(161, 22);
            this.allStudents_menu.Text = "All students";
            this.allStudents_menu.Click += new System.EventHandler(this.allStudentsToolStripMenuItem_Click);
            // 
            // leftStudents_menu
            // 
            this.leftStudents_menu.Image = ((System.Drawing.Image)(resources.GetObject("leftStudents_menu.Image")));
            this.leftStudents_menu.Name = "leftStudents_menu";
            this.leftStudents_menu.Size = new System.Drawing.Size(161, 22);
            this.leftStudents_menu.Text = "Left Students";
            this.leftStudents_menu.Click += new System.EventHandler(this.leftStudentsToolStripMenuItem_Click);
            // 
            // menu_employees
            // 
            this.menu_employees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEmployee_menu,
            this.editEmployee_menu,
            this.aEmployeePaymentToolStripMenuItem,
            this.allEmployeesWorking_menu,
            this.leftEmployees});
            this.menu_employees.Name = "menu_employees";
            this.menu_employees.Size = new System.Drawing.Size(76, 20);
            this.menu_employees.Text = "Employees";
            // 
            // newEmployee_menu
            // 
            this.newEmployee_menu.Image = ((System.Drawing.Image)(resources.GetObject("newEmployee_menu.Image")));
            this.newEmployee_menu.Name = "newEmployee_menu";
            this.newEmployee_menu.Size = new System.Drawing.Size(197, 22);
            this.newEmployee_menu.Text = "New employee";
            this.newEmployee_menu.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // editEmployee_menu
            // 
            this.editEmployee_menu.Image = ((System.Drawing.Image)(resources.GetObject("editEmployee_menu.Image")));
            this.editEmployee_menu.Name = "editEmployee_menu";
            this.editEmployee_menu.Size = new System.Drawing.Size(197, 22);
            this.editEmployee_menu.Text = "Edit an employee";
            this.editEmployee_menu.Click += new System.EventHandler(this.editEmployee_menu_Click);
            // 
            // aEmployeePaymentToolStripMenuItem
            // 
            this.aEmployeePaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aEmployeePaymentToolStripMenuItem.Image")));
            this.aEmployeePaymentToolStripMenuItem.Name = "aEmployeePaymentToolStripMenuItem";
            this.aEmployeePaymentToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.aEmployeePaymentToolStripMenuItem.Text = "An employee payment ";
            // 
            // allEmployeesWorking_menu
            // 
            this.allEmployeesWorking_menu.Image = ((System.Drawing.Image)(resources.GetObject("allEmployeesWorking_menu.Image")));
            this.allEmployeesWorking_menu.Name = "allEmployeesWorking_menu";
            this.allEmployeesWorking_menu.Size = new System.Drawing.Size(197, 22);
            this.allEmployeesWorking_menu.Text = "All employees working";
            this.allEmployeesWorking_menu.Click += new System.EventHandler(this.allEmployeesWorking_menu_Click);
            // 
            // leftEmployees
            // 
            this.leftEmployees.Image = ((System.Drawing.Image)(resources.GetObject("leftEmployees.Image")));
            this.leftEmployees.Name = "leftEmployees";
            this.leftEmployees.Size = new System.Drawing.Size(197, 22);
            this.leftEmployees.Text = "Left employees";
            this.leftEmployees.Click += new System.EventHandler(this.leftEmployees_Click);
            // 
            // menu_manageRooms
            // 
            this.menu_manageRooms.Name = "menu_manageRooms";
            this.menu_manageRooms.Size = new System.Drawing.Size(99, 20);
            this.menu_manageRooms.Text = "Manage rooms";
            this.menu_manageRooms.Click += new System.EventHandler(this.menu_manageRooms_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem feeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aEmployeePaymentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menu_students;
        public System.Windows.Forms.ToolStripMenuItem menu_employees;
        public System.Windows.Forms.ToolStripMenuItem menu_manageRooms;
        public System.Windows.Forms.ToolStripMenuItem admission_menu;
        public System.Windows.Forms.ToolStripMenuItem editStudent_menu;
        public System.Windows.Forms.ToolStripMenuItem allStudents_menu;
        public System.Windows.Forms.ToolStripMenuItem leftStudents_menu;
        public System.Windows.Forms.ToolStripMenuItem newEmployee_menu;
        public System.Windows.Forms.ToolStripMenuItem editEmployee_menu;
        public System.Windows.Forms.ToolStripMenuItem allEmployeesWorking_menu;
        public System.Windows.Forms.ToolStripMenuItem leftEmployees;
    }
}