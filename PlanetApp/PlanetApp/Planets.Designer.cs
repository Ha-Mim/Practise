namespace PlanetApp
{
    partial class Planets
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
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.searchPlanetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet Name";
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Sun",
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune"});
            this.planetNameComboBox.Location = new System.Drawing.Point(124, 45);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.planetNameComboBox.TabIndex = 1;
            // 
            // searchPlanetButton
            // 
            this.searchPlanetButton.Location = new System.Drawing.Point(108, 92);
            this.searchPlanetButton.Name = "searchPlanetButton";
            this.searchPlanetButton.Size = new System.Drawing.Size(75, 23);
            this.searchPlanetButton.TabIndex = 2;
            this.searchPlanetButton.Text = "Search Planet";
            this.searchPlanetButton.UseVisualStyleBackColor = true;
            this.searchPlanetButton.Click += new System.EventHandler(this.searchPlanetButton_Click);
            // 
            // Planets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.searchPlanetButton);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Planets";
            this.Text = "Planets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Button searchPlanetButton;
    }
}

