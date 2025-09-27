namespace LibraryManagementSystem
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtBookPublication = new System.Windows.Forms.TextBox();
            this.txtBookAuthurName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookQuatity = new System.Windows.Forms.Label();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookPurchaseDate = new System.Windows.Forms.Label();
            this.lblBookPublication = new System.Windows.Forms.Label();
            this.lblBookAuthurName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.lblAddBook);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 77);
            this.panel1.TabIndex = 1;
            // 
            // lblAddBook
            // 
            this.lblAddBook.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddBook.Location = new System.Drawing.Point(359, 30);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(110, 29);
            this.lblAddBook.TabIndex = 1;
            this.lblAddBook.Text = "Add Book";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtBookQuantity);
            this.panel2.Controls.Add(this.txtBookPrice);
            this.panel2.Controls.Add(this.txtBookPublication);
            this.panel2.Controls.Add(this.txtBookAuthurName);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.lblBookQuatity);
            this.panel2.Controls.Add(this.lblBookPrice);
            this.panel2.Controls.Add(this.lblBookPurchaseDate);
            this.panel2.Controls.Add(this.lblBookPublication);
            this.panel2.Controls.Add(this.lblBookAuthurName);
            this.panel2.Controls.Add(this.lblBookName);
            this.panel2.Location = new System.Drawing.Point(279, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 351);
            this.panel2.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(318, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Cancel";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(193, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(193, 224);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(200, 23);
            this.txtBookQuantity.TabIndex = 10;
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(193, 184);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(200, 23);
            this.txtBookPrice.TabIndex = 9;
            // 
            // txtBookPublication
            // 
            this.txtBookPublication.Location = new System.Drawing.Point(193, 104);
            this.txtBookPublication.Name = "txtBookPublication";
            this.txtBookPublication.Size = new System.Drawing.Size(200, 23);
            this.txtBookPublication.TabIndex = 8;
            // 
            // txtBookAuthurName
            // 
            this.txtBookAuthurName.Location = new System.Drawing.Point(193, 66);
            this.txtBookAuthurName.Name = "txtBookAuthurName";
            this.txtBookAuthurName.Size = new System.Drawing.Size(200, 23);
            this.txtBookAuthurName.TabIndex = 7;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(193, 27);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(200, 23);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // lblBookQuatity
            // 
            this.lblBookQuatity.AutoSize = true;
            this.lblBookQuatity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookQuatity.Location = new System.Drawing.Point(49, 225);
            this.lblBookQuatity.Name = "lblBookQuatity";
            this.lblBookQuatity.Size = new System.Drawing.Size(89, 17);
            this.lblBookQuatity.TabIndex = 5;
            this.lblBookQuatity.Text = "Book Quantity";
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPrice.Location = new System.Drawing.Point(49, 185);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(69, 17);
            this.lblBookPrice.TabIndex = 4;
            this.lblBookPrice.Text = "Book Price";
            // 
            // lblBookPurchaseDate
            // 
            this.lblBookPurchaseDate.AutoSize = true;
            this.lblBookPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPurchaseDate.Location = new System.Drawing.Point(49, 147);
            this.lblBookPurchaseDate.Name = "lblBookPurchaseDate";
            this.lblBookPurchaseDate.Size = new System.Drawing.Size(124, 17);
            this.lblBookPurchaseDate.TabIndex = 3;
            this.lblBookPurchaseDate.Text = "Book Purchase Date";
            // 
            // lblBookPublication
            // 
            this.lblBookPublication.AutoSize = true;
            this.lblBookPublication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookPublication.Location = new System.Drawing.Point(49, 105);
            this.lblBookPublication.Name = "lblBookPublication";
            this.lblBookPublication.Size = new System.Drawing.Size(104, 17);
            this.lblBookPublication.TabIndex = 2;
            this.lblBookPublication.Text = "Book Publication";
            // 
            // lblBookAuthurName
            // 
            this.lblBookAuthurName.AutoSize = true;
            this.lblBookAuthurName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookAuthurName.Location = new System.Drawing.Point(49, 67);
            this.lblBookAuthurName.Name = "lblBookAuthurName";
            this.lblBookAuthurName.Size = new System.Drawing.Size(118, 17);
            this.lblBookAuthurName.TabIndex = 1;
            this.lblBookAuthurName.Text = "Book Authur Name";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.Location = new System.Drawing.Point(49, 28);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(76, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblAddBook;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnClear;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBookQuantity;
        private TextBox txtBookPrice;
        private TextBox txtBookPublication;
        private TextBox txtBookAuthurName;
        private TextBox txtBookName;
        private Label lblBookQuatity;
        private Label lblBookPrice;
        private Label lblBookPurchaseDate;
        private Label lblBookPublication;
        private Label lblBookAuthurName;
        private Label lblBookName;
    }
}