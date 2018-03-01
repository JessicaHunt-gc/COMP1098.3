namespace SiS
{
    partial class CreateStudent
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.DateTimePicker();
            this.lblDoB = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AvailableCourses = new System.Windows.Forms.ListBox();
            this.RegisteredCourses = new System.Windows.Forms.ListBox();
            this.AddCourse = new System.Windows.Forms.Button();
            this.RemoveCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(104, 13);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(200, 20);
            this.FirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(104, 40);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(200, 20);
            this.LastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // DoB
            // 
            this.DoB.Location = new System.Drawing.Point(104, 67);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(200, 20);
            this.DoB.TabIndex = 2;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(13, 73);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(71, 13);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(230, 217);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(9, 217);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AvailableCourses
            // 
            this.AvailableCourses.FormattingEnabled = true;
            this.AvailableCourses.Location = new System.Drawing.Point(9, 90);
            this.AvailableCourses.Name = "AvailableCourses";
            this.AvailableCourses.Size = new System.Drawing.Size(130, 121);
            this.AvailableCourses.TabIndex = 6;
            // 
            // RegisteredCourses
            // 
            this.RegisteredCourses.FormattingEnabled = true;
            this.RegisteredCourses.Location = new System.Drawing.Point(170, 90);
            this.RegisteredCourses.Name = "RegisteredCourses";
            this.RegisteredCourses.Size = new System.Drawing.Size(134, 121);
            this.RegisteredCourses.TabIndex = 7;
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(146, 121);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(18, 23);
            this.AddCourse.TabIndex = 8;
            this.AddCourse.Text = ">";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // RemoveCourse
            // 
            this.RemoveCourse.Location = new System.Drawing.Point(145, 150);
            this.RemoveCourse.Name = "RemoveCourse";
            this.RemoveCourse.Size = new System.Drawing.Size(18, 23);
            this.RemoveCourse.TabIndex = 9;
            this.RemoveCourse.Text = "<";
            this.RemoveCourse.UseVisualStyleBackColor = true;
            this.RemoveCourse.Click += new System.EventHandler(this.RemoveCourse_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 248);
            this.Controls.Add(this.RemoveCourse);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.RegisteredCourses);
            this.Controls.Add(this.AvailableCourses);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "CreateStudent";
            this.Text = "Create Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker DoB;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ListBox AvailableCourses;
        private System.Windows.Forms.ListBox RegisteredCourses;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button RemoveCourse;
    }
}