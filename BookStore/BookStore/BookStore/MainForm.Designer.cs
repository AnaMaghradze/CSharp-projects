namespace BookStore
{
    partial class MainForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ManageCustomersButton = new System.Windows.Forms.Button();
            this.ManageBooksButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(109, 57);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(396, 34);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome To The Book Store!";
            // 
            // ManageCustomersButton
            // 
            this.ManageCustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageCustomersButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCustomersButton.Location = new System.Drawing.Point(190, 146);
            this.ManageCustomersButton.Name = "ManageCustomersButton";
            this.ManageCustomersButton.Size = new System.Drawing.Size(227, 41);
            this.ManageCustomersButton.TabIndex = 4;
            this.ManageCustomersButton.Text = "Manage Customers";
            this.ManageCustomersButton.UseVisualStyleBackColor = true;
            this.ManageCustomersButton.Click += new System.EventHandler(this.ManageCustomersButton_Click);
            // 
            // ManageBooksButton
            // 
            this.ManageBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageBooksButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBooksButton.Location = new System.Drawing.Point(190, 224);
            this.ManageBooksButton.Name = "ManageBooksButton";
            this.ManageBooksButton.Size = new System.Drawing.Size(227, 41);
            this.ManageBooksButton.TabIndex = 5;
            this.ManageBooksButton.Text = "Manage Books";
            this.ManageBooksButton.UseVisualStyleBackColor = true;
            this.ManageBooksButton.Click += new System.EventHandler(this.ManageBooksButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(190, 300);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(227, 41);
            this.PlaceOrderButton.TabIndex = 6;
            this.PlaceOrderButton.Text = "Place Order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 400);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.ManageBooksButton);
            this.Controls.Add(this.ManageCustomersButton);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ManageCustomersButton;
        private System.Windows.Forms.Button ManageBooksButton;
        private System.Windows.Forms.Button PlaceOrderButton;
    }
}