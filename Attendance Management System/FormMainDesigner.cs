namespace Attendance_Management_System.Main.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlDashboard1 = new Attendance_Management_System.Main.Forms.User_Control.UserControlDashboard();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelExpand.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.buttonAddStudent);
            this.panel1.Controls.Add(this.buttonAddClass);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 720);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 540);
            this.panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 47);
            this.panelSlide.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 180);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance Management";
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelExpand);
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.pictureBox2);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(313, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(887, 180);
            this.panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            this.panelExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelExpand.Controls.Add(this.buttonLogOut);
            this.panelExpand.Controls.Add(this.buttonMinimize);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(675, 52);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(200, 100);
            this.panelExpand.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 5);
            this.panel3.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(24, 23);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(35, 23);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "{?}";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.panelTop.Controls.Add(this.labelRole);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTop.Location = new System.Drawing.Point(0, 80);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(887, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(166, 58);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(35, 23);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "{?}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Role:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(166, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(35, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "{?}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick_1);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.White;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogOut.Image = global::Attendance_Management_System.Properties.Resources.sign_out;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 53);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(200, 48);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "   Log Out";
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonMinimize.Image = global::Attendance_Management_System.Properties.Resources.minimize_sign__1_;
            this.buttonMinimize.Location = new System.Drawing.Point(0, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(200, 48);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "   Minimize";
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click_1);
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::Attendance_Management_System.Properties.Resources.down;
            this.pictureBoxExpand.Location = new System.Drawing.Point(796, 34);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(27, 24);
            this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpand.TabIndex = 5;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Attendance_Management_System.Properties.Resources.Student_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(730, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Image = global::Attendance_Management_System.Properties.Resources.registered;
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.Location = new System.Drawing.Point(8, 415);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(305, 47);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "         Register";
            this.buttonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Image = global::Attendance_Management_System.Properties.Resources.clipboard;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(8, 368);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(305, 47);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "         Report";
            this.buttonReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click_1);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Image = global::Attendance_Management_System.Properties.Resources.student__1_;
            this.buttonAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStudent.Location = new System.Drawing.Point(8, 321);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(305, 47);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "         Add Student";
            this.buttonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click_1);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.ForeColor = System.Drawing.Color.White;
            this.buttonAddClass.Image = global::Attendance_Management_System.Properties.Resources.online_class;
            this.buttonAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClass.Location = new System.Drawing.Point(8, 274);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(305, 47);
            this.buttonAddClass.TabIndex = 0;
            this.buttonAddClass.Text = "         Add Class";
            this.buttonAddClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click_1);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonAttendance.Image = global::Attendance_Management_System.Properties.Resources.available;
            this.buttonAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.Location = new System.Drawing.Point(8, 227);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(305, 47);
            this.buttonAttendance.TabIndex = 0;
            this.buttonAttendance.Text = "         Attendance";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click_1);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::Attendance_Management_System.Properties.Resources.dashboard_monitor;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(8, 180);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(305, 47);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "         Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Attendance_Management_System.Properties.Resources.student_with_graduation_cap__1_;
            this.pictureBox1.Location = new System.Drawing.Point(104, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard1.Location = new System.Drawing.Point(313, 180);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(887, 540);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxExpand;
        private System.Windows.Forms.Panel panelExpand;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddClass;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Timer timerDateAndTime;
        private User_Control.UserControlDashboard userControlDashboard1;
    }
}
