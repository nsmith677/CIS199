namespace Program4
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.pubLabel = new System.Windows.Forms.Label();
            this.cyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnLabel = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.cnTxtBox = new System.Windows.Forms.TextBox();
            this.cyTxtBox = new System.Windows.Forms.TextBox();
            this.pubTxtBox = new System.Windows.Forms.TextBox();
            this.authorTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(99, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(80, 128);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(81, 25);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // pubLabel
            // 
            this.pubLabel.AutoSize = true;
            this.pubLabel.Location = new System.Drawing.Point(55, 170);
            this.pubLabel.Name = "pubLabel";
            this.pubLabel.Size = new System.Drawing.Size(108, 25);
            this.pubLabel.TabIndex = 2;
            this.pubLabel.Text = "Publisher:";
            // 
            // cyLabel
            // 
            this.cyLabel.AutoSize = true;
            this.cyLabel.Location = new System.Drawing.Point(3, 211);
            this.cyLabel.Name = "cyLabel";
            this.cyLabel.Size = new System.Drawing.Size(162, 25);
            this.cyLabel.TabIndex = 3;
            this.cyLabel.Text = "Copyright Year:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnLabel);
            this.groupBox1.Controls.Add(this.cyLabel);
            this.groupBox1.Controls.Add(this.addBookBtn);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Controls.Add(this.cnTxtBox);
            this.groupBox1.Controls.Add(this.authorLabel);
            this.groupBox1.Controls.Add(this.cyTxtBox);
            this.groupBox1.Controls.Add(this.pubLabel);
            this.groupBox1.Controls.Add(this.pubTxtBox);
            this.groupBox1.Controls.Add(this.authorTxtBox);
            this.groupBox1.Controls.Add(this.titleTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 408);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Book Data";
            // 
            // cnLabel
            // 
            this.cnLabel.AutoSize = true;
            this.cnLabel.Location = new System.Drawing.Point(27, 250);
            this.cnLabel.Name = "cnLabel";
            this.cnLabel.Size = new System.Drawing.Size(136, 25);
            this.cnLabel.TabIndex = 5;
            this.cnLabel.Text = "Call Number:";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(151, 308);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(126, 60);
            this.addBookBtn.TabIndex = 11;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // cnTxtBox
            // 
            this.cnTxtBox.Location = new System.Drawing.Point(166, 248);
            this.cnTxtBox.Name = "cnTxtBox";
            this.cnTxtBox.Size = new System.Drawing.Size(233, 31);
            this.cnTxtBox.TabIndex = 10;
            // 
            // cyTxtBox
            // 
            this.cyTxtBox.Location = new System.Drawing.Point(166, 208);
            this.cyTxtBox.Name = "cyTxtBox";
            this.cyTxtBox.Size = new System.Drawing.Size(233, 31);
            this.cyTxtBox.TabIndex = 9;
            // 
            // pubTxtBox
            // 
            this.pubTxtBox.Location = new System.Drawing.Point(166, 167);
            this.pubTxtBox.Name = "pubTxtBox";
            this.pubTxtBox.Size = new System.Drawing.Size(233, 31);
            this.pubTxtBox.TabIndex = 8;
            // 
            // authorTxtBox
            // 
            this.authorTxtBox.Location = new System.Drawing.Point(166, 122);
            this.authorTxtBox.Name = "authorTxtBox";
            this.authorTxtBox.Size = new System.Drawing.Size(233, 31);
            this.authorTxtBox.TabIndex = 7;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(166, 80);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(233, 31);
            this.titleTxtBox.TabIndex = 6;
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 25;
            this.bookListBox.Location = new System.Drawing.Point(62, 50);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(330, 204);
            this.bookListBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detailsBtn);
            this.groupBox2.Controls.Add(this.checkOutBtn);
            this.groupBox2.Controls.Add(this.returnBtn);
            this.groupBox2.Controls.Add(this.bookListBox);
            this.groupBox2.Location = new System.Drawing.Point(501, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 392);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Book";
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(53, 288);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(117, 70);
            this.detailsBtn.TabIndex = 7;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(176, 288);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(117, 70);
            this.checkOutBtn.TabIndex = 8;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(299, 288);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(118, 70);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label pubLabel;
        private System.Windows.Forms.Label cyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.TextBox cnTxtBox;
        private System.Windows.Forms.TextBox cyTxtBox;
        private System.Windows.Forms.TextBox pubTxtBox;
        private System.Windows.Forms.TextBox authorTxtBox;
        private System.Windows.Forms.Label cnLabel;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.ListBox bookListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}

