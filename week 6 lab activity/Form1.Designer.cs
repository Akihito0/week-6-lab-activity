namespace week_6_lab_activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            HeaderNames = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            EmailAdd = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            JobType = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            submitbtn = new Button();
            editbtn = new Button();
            loadbtn = new Button();
            postbx = new ComboBox();
            deletebtn = new Button();
            clearbtn = new Button();
            savebtn = new Button();
            typetbx = new TextBox();
            label6 = new Label();
            depttbx = new TextBox();
            label5 = new Label();
            emailAddtbx = new TextBox();
            label4 = new Label();
            label3 = new Label();
            agetbx = new TextBox();
            label2 = new Label();
            employeeIDtxb = new TextBox();
            label1 = new Label();
            nametbx = new TextBox();
            Namelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HeaderNames, EmployeeID, Age, Position, EmailAdd, Department, JobType });
            dataGridView1.Location = new Point(335, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(790, 631);
            dataGridView1.TabIndex = 0;
            // 
            // HeaderNames
            // 
            HeaderNames.HeaderText = "Name";
            HeaderNames.Name = "HeaderNames";
            HeaderNames.ReadOnly = true;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Position
            // 
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.ReadOnly = true;
            // 
            // EmailAdd
            // 
            EmailAdd.HeaderText = "Email Address";
            EmailAdd.Name = "EmailAdd";
            EmailAdd.ReadOnly = true;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // JobType
            // 
            JobType.HeaderText = "Type";
            JobType.Name = "JobType";
            JobType.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(submitbtn);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(loadbtn);
            panel1.Controls.Add(postbx);
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(clearbtn);
            panel1.Controls.Add(savebtn);
            panel1.Controls.Add(typetbx);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(depttbx);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emailAddtbx);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(agetbx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(employeeIDtxb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nametbx);
            panel1.Controls.Add(Namelbl);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 631);
            panel1.TabIndex = 1;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(154, 550);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(109, 39);
            submitbtn.TabIndex = 21;
            submitbtn.Text = "Add";
            submitbtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(154, 460);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(109, 39);
            editbtn.TabIndex = 20;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(39, 460);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(109, 39);
            loadbtn.TabIndex = 19;
            loadbtn.Text = "Open";
            loadbtn.UseVisualStyleBackColor = true;
            // 
            // postbx
            // 
            postbx.FormattingEnabled = true;
            postbx.Items.AddRange(new object[] { "Team Leader", "Manager", "Assistant Manager", "Executive", "Director", "Coordinator", "Administrator", "Controller", "Officer", "Organizer", "Supervisor", "Superintendent", "Head", "Overseer", "Chief", "Foreman", "Controller", "Principal", "President", "Lead" });
            postbx.Location = new Point(34, 218);
            postbx.Name = "postbx";
            postbx.Size = new Size(272, 23);
            postbx.TabIndex = 18;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(154, 505);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(109, 39);
            deletebtn.TabIndex = 17;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(39, 550);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(109, 39);
            clearbtn.TabIndex = 16;
            clearbtn.Text = "Clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(39, 505);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(109, 39);
            savebtn.TabIndex = 15;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            // 
            // typetbx
            // 
            typetbx.Location = new Point(34, 408);
            typetbx.Name = "typetbx";
            typetbx.Size = new Size(272, 23);
            typetbx.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 380);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 13;
            label6.Text = "Type:";
            // 
            // depttbx
            // 
            depttbx.Location = new Point(34, 345);
            depttbx.Name = "depttbx";
            depttbx.Size = new Size(272, 23);
            depttbx.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 317);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 11;
            label5.Text = "Department";
            // 
            // emailAddtbx
            // 
            emailAddtbx.Location = new Point(34, 282);
            emailAddtbx.Name = "emailAddtbx";
            emailAddtbx.Size = new Size(272, 23);
            emailAddtbx.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 254);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 9;
            label4.Text = "Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 194);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 7;
            label3.Text = "Position:";
            // 
            // agetbx
            // 
            agetbx.Location = new Point(34, 165);
            agetbx.Name = "agetbx";
            agetbx.Size = new Size(272, 23);
            agetbx.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 137);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // employeeIDtxb
            // 
            employeeIDtxb.Location = new Point(34, 111);
            employeeIDtxb.Name = "employeeIDtxb";
            employeeIDtxb.Size = new Size(272, 23);
            employeeIDtxb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 83);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 3;
            label1.Text = "Empolyee ID:";
            // 
            // nametbx
            // 
            nametbx.Location = new Point(34, 57);
            nametbx.Name = "nametbx";
            nametbx.Size = new Size(272, 23);
            nametbx.TabIndex = 2;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Namelbl.Location = new Point(34, 29);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(55, 21);
            Namelbl.TabIndex = 1;
            Namelbl.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 631);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox employeeIDtxb;
        private Label Namelbl;
        private TextBox nametbx;
        private Label label1;
        private ComboBox postbx;
        private Button deletebtn;
        private Button clearbtn;
        private Button savebtn;
        private TextBox typetbx;
        private Label label6;
        private TextBox depttbx;
        private Label label5;
        private TextBox emailAddtbx;
        private Label label4;
        private Label label3;
        private TextBox agetbx;
        private Label label2;
        private DataGridViewTextBoxColumn HeaderNames;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn EmailAdd;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn JobType;
        private Button submitbtn;
        private Button editbtn;
        private Button loadbtn;
    }
}
