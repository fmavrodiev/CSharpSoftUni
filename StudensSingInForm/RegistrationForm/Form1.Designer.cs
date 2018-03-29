namespace RegistrationForm
{
    partial class Form1
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
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentSurname = new System.Windows.Forms.TextBox();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.universityName = new System.Windows.Forms.TextBox();
            this.studentSpeciality = new System.Windows.Forms.TextBox();
            this.educationFormType = new System.Windows.Forms.TextBox();
            this.studentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(1150, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 54);
            this.save.TabIndex = 0;
            this.save.Text = "Запази";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(1150, 72);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 54);
            this.search.TabIndex = 1;
            this.search.Text = "Търси";
            this.search.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1150, 132);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 54);
            this.delete.TabIndex = 2;
            this.delete.Text = "Изтрий";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1150, 192);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(89, 54);
            this.exit.TabIndex = 3;
            this.exit.Text = "Излез";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(12, 12);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(239, 22);
            this.studentName.TabIndex = 4;
            this.studentName.TextChanged += new System.EventHandler(this.studentName_TextChanged);
            // 
            // studentSurname
            // 
            this.studentSurname.Location = new System.Drawing.Point(12, 40);
            this.studentSurname.Name = "studentSurname";
            this.studentSurname.Size = new System.Drawing.Size(239, 22);
            this.studentSurname.TabIndex = 5;
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(12, 68);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(239, 22);
            this.studentNumber.TabIndex = 6;
            // 
            // universityName
            // 
            this.universityName.Location = new System.Drawing.Point(12, 96);
            this.universityName.Name = "universityName";
            this.universityName.Size = new System.Drawing.Size(239, 22);
            this.universityName.TabIndex = 7;
            // 
            // studentSpeciality
            // 
            this.studentSpeciality.Location = new System.Drawing.Point(12, 124);
            this.studentSpeciality.Name = "studentSpeciality";
            this.studentSpeciality.Size = new System.Drawing.Size(239, 22);
            this.studentSpeciality.TabIndex = 8;
            // 
            // educationFormType
            // 
            this.educationFormType.Location = new System.Drawing.Point(12, 180);
            this.educationFormType.Name = "educationFormType";
            this.educationFormType.Size = new System.Drawing.Size(239, 22);
            this.educationFormType.TabIndex = 10;
            // 
            // studentDateOfBirth
            // 
            this.studentDateOfBirth.Location = new System.Drawing.Point(12, 152);
            this.studentDateOfBirth.Name = "studentDateOfBirth";
            this.studentDateOfBirth.Size = new System.Drawing.Size(239, 22);
            this.studentDateOfBirth.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1227, 484);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 753);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.studentDateOfBirth);
            this.Controls.Add(this.educationFormType);
            this.Controls.Add(this.studentSpeciality);
            this.Controls.Add(this.universityName);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.studentSurname);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.save);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentSurname;
        private System.Windows.Forms.TextBox studentNumber;
        private System.Windows.Forms.TextBox universityName;
        private System.Windows.Forms.TextBox studentSpeciality;
        private System.Windows.Forms.TextBox educationFormType;
        private System.Windows.Forms.DateTimePicker studentDateOfBirth;
        private System.Windows.Forms.ListBox listBox1;
    }
}

