namespace Prog2
{
    partial class Prog2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prog2));
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.directionsLabel = new System.Windows.Forms.Label();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationButton = new System.Windows.Forms.Button();
            this.uoflPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uoflPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(97, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(2, 59);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(89, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter Last Name:";
            // 
            // directionsLabel
            // 
            this.directionsLabel.Location = new System.Drawing.Point(12, 9);
            this.directionsLabel.Name = "directionsLabel";
            this.directionsLabel.Size = new System.Drawing.Size(369, 44);
            this.directionsLabel.TabIndex = 2;
            this.directionsLabel.Text = "Please enter your last name in the space provided and choose which status applies" +
    " to you. (Credit hour total prior to Spring 2015 must be chosen!)";
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(15, 172);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(186, 17);
            this.freshmanRadioButton.TabIndex = 3;
            this.freshmanRadioButton.Text = "Freshman (29 or less Credit Hours)";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(15, 149);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(176, 17);
            this.sophomoreRadioButton.TabIndex = 4;
            this.sophomoreRadioButton.Text = "Sophomore (30-59 Credit Hours)";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(15, 126);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(150, 17);
            this.juniorRadioButton.TabIndex = 5;
            this.juniorRadioButton.Text = "Junior (60-89 Credit Hours)";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Checked = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(15, 103);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(143, 17);
            this.seniorRadioButton.TabIndex = 6;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior (90+ Credit Hours)";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(131, 238);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(149, 23);
            this.registrationButton.TabIndex = 7;
            this.registrationButton.Text = "Find Registration Time";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // uoflPictureBox
            // 
            this.uoflPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uoflPictureBox.BackgroundImage")));
            this.uoflPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uoflPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uoflPictureBox.Location = new System.Drawing.Point(250, 89);
            this.uoflPictureBox.Name = "uoflPictureBox";
            this.uoflPictureBox.Size = new System.Drawing.Size(131, 115);
            this.uoflPictureBox.TabIndex = 8;
            this.uoflPictureBox.TabStop = false;
            // 
            // Prog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 273);
            this.Controls.Add(this.uoflPictureBox);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.seniorRadioButton);
            this.Controls.Add(this.juniorRadioButton);
            this.Controls.Add(this.sophomoreRadioButton);
            this.Controls.Add(this.freshmanRadioButton);
            this.Controls.Add(this.directionsLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Name = "Prog2";
            this.Text = "Priority Early Registration Tool";
            ((System.ComponentModel.ISupportInitialize)(this.uoflPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label directionsLabel;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.PictureBox uoflPictureBox;
    }
}

