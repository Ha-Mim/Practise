namespace PersonalInformationApp
{
    partial class personalInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllInformationButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parentsNameButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Father\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mother\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(117, 30);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(117, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(117, 101);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherNameTextBox.TabIndex = 8;
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(117, 139);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherNameTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(117, 176);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(169, 43);
            this.addressTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(56, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllInformationButton
            // 
            this.showAllInformationButton.Location = new System.Drawing.Point(141, 237);
            this.showAllInformationButton.Name = "showAllInformationButton";
            this.showAllInformationButton.Size = new System.Drawing.Size(145, 23);
            this.showAllInformationButton.TabIndex = 12;
            this.showAllInformationButton.Text = "Show All Information";
            this.showAllInformationButton.UseVisualStyleBackColor = true;
            this.showAllInformationButton.Click += new System.EventHandler(this.showAllInformationButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(22, 276);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 13;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parentsNameButton
            // 
            this.parentsNameButton.Location = new System.Drawing.Point(117, 276);
            this.parentsNameButton.Name = "parentsNameButton";
            this.parentsNameButton.Size = new System.Drawing.Size(109, 23);
            this.parentsNameButton.TabIndex = 14;
            this.parentsNameButton.Text = "Parent\'s Name";
            this.parentsNameButton.UseVisualStyleBackColor = true;
            this.parentsNameButton.Click += new System.EventHandler(this.parentsNameButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(253, 276);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 15;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // personalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 331);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parentsNameButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.showAllInformationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "personalInfo";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllInformationButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parentsNameButton;
        private System.Windows.Forms.Button addressButton;
    }
}

