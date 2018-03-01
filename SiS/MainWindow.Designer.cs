namespace SiS
{
    partial class MainWindow
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
            this.CreateStudent = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.CreateStaff = new System.Windows.Forms.Button();
            this.ProgramGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseGrid = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credential = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateStudent
            // 
            this.CreateStudent.Location = new System.Drawing.Point(461, 433);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(100, 23);
            this.CreateStudent.TabIndex = 0;
            this.CreateStudent.Text = "Create Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.AllowUserToAddRows = false;
            this.StudentGridView.AllowUserToDeleteRows = false;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.FirstName,
            this.LastName,
            this.Type});
            this.StudentGridView.Location = new System.Drawing.Point(13, 77);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridView.Size = new System.Drawing.Size(548, 95);
            this.StudentGridView.TabIndex = 1;
            // 
            // CreateStaff
            // 
            this.CreateStaff.Location = new System.Drawing.Point(13, 433);
            this.CreateStaff.Name = "CreateStaff";
            this.CreateStaff.Size = new System.Drawing.Size(75, 23);
            this.CreateStaff.TabIndex = 2;
            this.CreateStaff.Text = "Create Staff";
            this.CreateStaff.UseVisualStyleBackColor = true;
            this.CreateStaff.Click += new System.EventHandler(this.CreateStaff_Click);
            // 
            // ProgramGrid
            // 
            this.ProgramGrid.AllowUserToAddRows = false;
            this.ProgramGrid.AllowUserToDeleteRows = false;
            this.ProgramGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.Credential,
            this.Years,
            this.Courses});
            this.ProgramGrid.Location = new System.Drawing.Point(12, 191);
            this.ProgramGrid.Name = "ProgramGrid";
            this.ProgramGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProgramGrid.Size = new System.Drawing.Size(549, 95);
            this.ProgramGrid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "People:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "College Programs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Courses";
            // 
            // CourseGrid
            // 
            this.CourseGrid.AllowUserToAddRows = false;
            this.CourseGrid.AllowUserToDeleteRows = false;
            this.CourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.Subject,
            this.Number,
            this.Capacity,
            this.Registered});
            this.CourseGrid.Location = new System.Drawing.Point(12, 305);
            this.CourseGrid.Name = "CourseGrid";
            this.CourseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseGrid.Size = new System.Drawing.Size(548, 95);
            this.CourseGrid.TabIndex = 7;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "ID";
            this.PersonID.Name = "PersonID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Registered
            // 
            this.Registered.HeaderText = "# Registered";
            this.Registered.Name = "Registered";
            this.Registered.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // Credential
            // 
            this.Credential.HeaderText = "Credential";
            this.Credential.Name = "Credential";
            this.Credential.ReadOnly = true;
            // 
            // Years
            // 
            this.Years.HeaderText = "Years";
            this.Years.Name = "Years";
            this.Years.ReadOnly = true;
            // 
            // Courses
            // 
            this.Courses.HeaderText = "Courses";
            this.Courses.Name = "Courses";
            this.Courses.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 469);
            this.Controls.Add(this.CourseGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgramGrid);
            this.Controls.Add(this.CreateStaff);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.CreateStudent);
            this.Name = "MainWindow";
            this.Text = "Student System";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button CreateStaff;
        private System.Windows.Forms.DataGridView ProgramGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CourseGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registered;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credential;
        private System.Windows.Forms.DataGridViewTextBoxColumn Years;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courses;
    }
}