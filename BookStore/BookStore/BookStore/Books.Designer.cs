namespace BookStore
{
    partial class BooksForm
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
            this.BookCancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewBookButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BooksComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BookCancelButton
            // 
            this.BookCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookCancelButton.Location = new System.Drawing.Point(656, 224);
            this.BookCancelButton.Name = "BookCancelButton";
            this.BookCancelButton.Size = new System.Drawing.Size(134, 31);
            this.BookCancelButton.TabIndex = 43;
            this.BookCancelButton.Text = "Cancel";
            this.BookCancelButton.UseVisualStyleBackColor = true;
            this.BookCancelButton.Click += new System.EventHandler(this.BookCancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(656, 162);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(134, 31);
            this.SaveButton.TabIndex = 42;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewBookButton
            // 
            this.NewBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewBookButton.Location = new System.Drawing.Point(656, 101);
            this.NewBookButton.Name = "NewBookButton";
            this.NewBookButton.Size = new System.Drawing.Size(134, 31);
            this.NewBookButton.TabIndex = 41;
            this.NewBookButton.Text = "New Book";
            this.NewBookButton.UseVisualStyleBackColor = true;
            this.NewBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(656, 41);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 31);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(96, 279);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(515, 20);
            this.PriceTextBox.TabIndex = 39;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(23, 282);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(36, 14);
            this.PriceLabel.TabIndex = 38;
            this.PriceLabel.Text = "Price";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(96, 159);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(515, 20);
            this.AuthorTextBox.TabIndex = 33;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(23, 162);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(49, 14);
            this.AuthorLabel.TabIndex = 32;
            this.AuthorLabel.Text = "Author";
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(96, 220);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(515, 20);
            this.ISBNTextBox.TabIndex = 31;
            this.ISBNTextBox.TextChanged += new System.EventHandler(this.ISBNTextBox_TextChanged);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(23, 224);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(34, 14);
            this.ISBNLabel.TabIndex = 30;
            this.ISBNLabel.Text = "ISBN";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(96, 98);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(515, 20);
            this.TitleTextBox.TabIndex = 25;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(23, 101);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 14);
            this.TitleLabel.TabIndex = 24;
            this.TitleLabel.Text = "Title";
            // 
            // BooksComboBox
            // 
            this.BooksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BooksComboBox.FormattingEnabled = true;
            this.BooksComboBox.Location = new System.Drawing.Point(26, 41);
            this.BooksComboBox.Name = "BooksComboBox";
            this.BooksComboBox.Size = new System.Drawing.Size(585, 22);
            this.BooksComboBox.TabIndex = 23;
            this.BooksComboBox.SelectedIndexChanged += new System.EventHandler(this.BooksComboBox_SelectedIndexChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 343);
            this.Controls.Add(this.BookCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewBookButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BooksComboBox);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "BooksForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BookCancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewBookButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox BooksComboBox;
    }
}