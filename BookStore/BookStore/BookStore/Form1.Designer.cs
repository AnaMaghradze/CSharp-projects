namespace BookStore
{
    partial class BookStoreForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.DataList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Order Summary";
            // 
            // DataList
            // 
            this.DataList.AllowUserToAddRows = false;
            this.DataList.AllowUserToDeleteRows = false;
            this.DataList.AllowUserToResizeColumns = false;
            this.DataList.AllowUserToResizeRows = false;
            this.DataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.QTY,
            this.LineTotal});
            this.DataList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataList.Location = new System.Drawing.Point(76, 319);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataList.Name = "DataList";
            this.DataList.ReadOnly = true;
            this.DataList.Size = new System.Drawing.Size(623, 147);
            this.DataList.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 100;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 110;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 110;
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.Name = "LineTotal";
            this.LineTotal.ReadOnly = true;
            this.LineTotal.Width = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Subtotal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(308, 497);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tax : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(524, 497);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total : ";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SubtotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubtotalTextBox.Location = new System.Drawing.Point(142, 493);
            this.SubtotalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.SubtotalTextBox.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(194, 558);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "Confirm Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(428, 558);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cancel Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuantityTextBox.Location = new System.Drawing.Point(459, 169);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(258, 20);
            this.QuantityTextBox.TabIndex = 25;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            this.QuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateQuantity);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(391, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity :";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTextBox.ForeColor = System.Drawing.Color.Black;
            this.PriceTextBox.Location = new System.Drawing.Point(99, 169);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(258, 20);
            this.PriceTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Price : ";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IsbnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IsbnTextBox.ForeColor = System.Drawing.Color.Black;
            this.IsbnTextBox.Location = new System.Drawing.Point(459, 127);
            this.IsbnTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.ReadOnly = true;
            this.IsbnTextBox.Size = new System.Drawing.Size(258, 20);
            this.IsbnTextBox.TabIndex = 21;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AuthorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorTextBox.ForeColor = System.Drawing.Color.Black;
            this.AuthorTextBox.Location = new System.Drawing.Point(99, 127);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.ReadOnly = true;
            this.AuthorTextBox.Size = new System.Drawing.Size(258, 20);
            this.AuthorTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(407, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "ISBN :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Author :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 15;
            this.comboBox1.Location = new System.Drawing.Point(44, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(672, 23);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxTextBox.Location = new System.Drawing.Point(355, 493);
            this.TaxTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(121, 20);
            this.TaxTextBox.TabIndex = 27;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTextBox.Location = new System.Drawing.Point(579, 493);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.TotalTextBox.TabIndex = 28;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.ItemHeight = 15;
            this.CustomerComboBox.Location = new System.Drawing.Point(44, 31);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(672, 23);
            this.CustomerComboBox.TabIndex = 29;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // BookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookStore.Properties.Resources.books;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 621);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsbnTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BookStoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Choose A Book";
            this.Text = "Book Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.ComboBox CustomerComboBox;
    }
}

