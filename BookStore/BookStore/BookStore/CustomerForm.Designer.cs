namespace BookStore
{
    partial class CustomerForm
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
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomerCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(34, 31);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(630, 22);
            this.CustomerComboBox.TabIndex = 0;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(31, 92);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(71, 14);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(104, 88);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(434, 88);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.LastNameTextBox.TabIndex = 4;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(360, 92);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(68, 14);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(104, 338);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(560, 20);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(31, 341);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 14);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(104, 211);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(560, 20);
            this.PhoneTextBox.TabIndex = 8;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(31, 214);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(42, 14);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(104, 150);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(560, 20);
            this.EmailTextBox.TabIndex = 10;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(31, 153);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 14);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(31, 398);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(37, 14);
            this.StateLabel.TabIndex = 11;
            this.StateLabel.Text = "State";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(360, 398);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(55, 14);
            this.ZipLabel.TabIndex = 13;
            this.ZipLabel.Text = "Zip Code";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(104, 395);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(229, 20);
            this.StateTextBox.TabIndex = 15;
            this.StateTextBox.TextChanged += new System.EventHandler(this.StateTextBox_TextChanged);
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(434, 395);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(229, 20);
            this.ZipTextBox.TabIndex = 16;
            this.ZipTextBox.TextChanged += new System.EventHandler(this.ZipTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(104, 276);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(560, 20);
            this.AddressTextBox.TabIndex = 18;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(31, 279);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 14);
            this.AddressLabel.TabIndex = 17;
            this.AddressLabel.Text = "Address";
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(724, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 31);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewCustomerButton.Location = new System.Drawing.Point(724, 92);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(134, 31);
            this.NewCustomerButton.TabIndex = 20;
            this.NewCustomerButton.Text = "New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(724, 153);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(134, 31);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomerCancelButton
            // 
            this.CustomerCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerCancelButton.Location = new System.Drawing.Point(724, 214);
            this.CustomerCancelButton.Name = "CustomerCancelButton";
            this.CustomerCancelButton.Size = new System.Drawing.Size(134, 31);
            this.CustomerCancelButton.TabIndex = 22;
            this.CustomerCancelButton.Text = "Cancel";
            this.CustomerCancelButton.UseVisualStyleBackColor = true;
            this.CustomerCancelButton.Click += new System.EventHandler(this.CustomerCancelButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(906, 447);
            this.Controls.Add(this.CustomerCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ZipTextBox);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CustomerCancelButton;
    }
}