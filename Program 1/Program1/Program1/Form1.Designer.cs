namespace Program1
{
    partial class programOneForm
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
            this.sqftWallLabel = new System.Windows.Forms.Label();
            this.sqftTxtBox = new System.Windows.Forms.TextBox();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.paintPriceTxtBox = new System.Windows.Forms.TextBox();
            this.numberCoatsLabel = new System.Windows.Forms.Label();
            this.numberCoatsTxtBox = new System.Windows.Forms.TextBox();
            this.totalSqftLabel = new System.Windows.Forms.Label();
            this.totalSqftOutputLabel = new System.Windows.Forms.Label();
            this.gallonsRequiredLabel = new System.Windows.Forms.Label();
            this.gallonsRequiredOutputLabel = new System.Windows.Forms.Label();
            this.hoursRequiredLabel = new System.Windows.Forms.Label();
            this.hoursRequiredOutputLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.paintCostOutputLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.laborCostOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqftWallLabel
            // 
            this.sqftWallLabel.AutoSize = true;
            this.sqftWallLabel.Location = new System.Drawing.Point(45, 76);
            this.sqftWallLabel.Name = "sqftWallLabel";
            this.sqftWallLabel.Size = new System.Drawing.Size(481, 25);
            this.sqftWallLabel.TabIndex = 0;
            this.sqftWallLabel.Text = "Enter square footage of wall space to be painted:";
            // 
            // sqftTxtBox
            // 
            this.sqftTxtBox.Location = new System.Drawing.Point(532, 73);
            this.sqftTxtBox.Name = "sqftTxtBox";
            this.sqftTxtBox.Size = new System.Drawing.Size(231, 31);
            this.sqftTxtBox.TabIndex = 1;
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(226, 167);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(300, 25);
            this.paintPriceLabel.TabIndex = 2;
            this.paintPriceLabel.Text = "Enter price of paint per gallon:";
            // 
            // paintPriceTxtBox
            // 
            this.paintPriceTxtBox.Location = new System.Drawing.Point(532, 165);
            this.paintPriceTxtBox.Name = "paintPriceTxtBox";
            this.paintPriceTxtBox.Size = new System.Drawing.Size(231, 31);
            this.paintPriceTxtBox.TabIndex = 3;
            // 
            // numberCoatsLabel
            // 
            this.numberCoatsLabel.AutoSize = true;
            this.numberCoatsLabel.Location = new System.Drawing.Point(184, 123);
            this.numberCoatsLabel.Name = "numberCoatsLabel";
            this.numberCoatsLabel.Size = new System.Drawing.Size(342, 25);
            this.numberCoatsLabel.TabIndex = 4;
            this.numberCoatsLabel.Text = "Enter the number of coats of paint:";
            // 
            // numberCoatsTxtBox
            // 
            this.numberCoatsTxtBox.Location = new System.Drawing.Point(532, 120);
            this.numberCoatsTxtBox.Name = "numberCoatsTxtBox";
            this.numberCoatsTxtBox.Size = new System.Drawing.Size(231, 31);
            this.numberCoatsTxtBox.TabIndex = 2;
            // 
            // totalSqftLabel
            // 
            this.totalSqftLabel.AutoSize = true;
            this.totalSqftLabel.Location = new System.Drawing.Point(215, 235);
            this.totalSqftLabel.Name = "totalSqftLabel";
            this.totalSqftLabel.Size = new System.Drawing.Size(311, 25);
            this.totalSqftLabel.TabIndex = 6;
            this.totalSqftLabel.Text = "Total square feet to be painted:";
            // 
            // totalSqftOutputLabel
            // 
            this.totalSqftOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSqftOutputLabel.Location = new System.Drawing.Point(532, 231);
            this.totalSqftOutputLabel.Name = "totalSqftOutputLabel";
            this.totalSqftOutputLabel.Size = new System.Drawing.Size(231, 34);
            this.totalSqftOutputLabel.TabIndex = 7;
            // 
            // gallonsRequiredLabel
            // 
            this.gallonsRequiredLabel.AutoSize = true;
            this.gallonsRequiredLabel.Location = new System.Drawing.Point(249, 286);
            this.gallonsRequiredLabel.Name = "gallonsRequiredLabel";
            this.gallonsRequiredLabel.Size = new System.Drawing.Size(277, 25);
            this.gallonsRequiredLabel.TabIndex = 8;
            this.gallonsRequiredLabel.Text = "Number of gallons required:";
            // 
            // gallonsRequiredOutputLabel
            // 
            this.gallonsRequiredOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsRequiredOutputLabel.Location = new System.Drawing.Point(532, 282);
            this.gallonsRequiredOutputLabel.Name = "gallonsRequiredOutputLabel";
            this.gallonsRequiredOutputLabel.Size = new System.Drawing.Size(230, 33);
            this.gallonsRequiredOutputLabel.TabIndex = 9;
            // 
            // hoursRequiredLabel
            // 
            this.hoursRequiredLabel.AutoSize = true;
            this.hoursRequiredLabel.Location = new System.Drawing.Point(288, 335);
            this.hoursRequiredLabel.Name = "hoursRequiredLabel";
            this.hoursRequiredLabel.Size = new System.Drawing.Size(238, 25);
            this.hoursRequiredLabel.TabIndex = 10;
            this.hoursRequiredLabel.Text = "Hours of labor required:";
            // 
            // hoursRequiredOutputLabel
            // 
            this.hoursRequiredOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursRequiredOutputLabel.Location = new System.Drawing.Point(532, 332);
            this.hoursRequiredOutputLabel.Name = "hoursRequiredOutputLabel";
            this.hoursRequiredOutputLabel.Size = new System.Drawing.Size(230, 33);
            this.hoursRequiredOutputLabel.TabIndex = 11;
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(351, 383);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(175, 25);
            this.paintCostLabel.TabIndex = 12;
            this.paintCostLabel.Text = "Cost of the paint:";
            // 
            // paintCostOutputLabel
            // 
            this.paintCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintCostOutputLabel.Location = new System.Drawing.Point(532, 380);
            this.paintCostOutputLabel.Name = "paintCostOutputLabel";
            this.paintCostOutputLabel.Size = new System.Drawing.Size(230, 33);
            this.paintCostOutputLabel.TabIndex = 13;
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(386, 433);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(140, 25);
            this.laborCostLabel.TabIndex = 14;
            this.laborCostLabel.Text = "Cost of labor:";
            // 
            // laborCostOutputLabel
            // 
            this.laborCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutputLabel.Location = new System.Drawing.Point(532, 429);
            this.laborCostOutputLabel.Name = "laborCostOutputLabel";
            this.laborCostOutputLabel.Size = new System.Drawing.Size(230, 33);
            this.laborCostOutputLabel.TabIndex = 15;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(266, 507);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(260, 25);
            this.totalCostLabel.TabIndex = 16;
            this.totalCostLabel.Text = "Total cost of the paint job:";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(532, 504);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(230, 33);
            this.totalCostOutputLabel.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(50, 393);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(147, 139);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // programOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 595);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.laborCostOutputLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostOutputLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.hoursRequiredOutputLabel);
            this.Controls.Add(this.hoursRequiredLabel);
            this.Controls.Add(this.gallonsRequiredOutputLabel);
            this.Controls.Add(this.gallonsRequiredLabel);
            this.Controls.Add(this.totalSqftOutputLabel);
            this.Controls.Add(this.totalSqftLabel);
            this.Controls.Add(this.numberCoatsTxtBox);
            this.Controls.Add(this.numberCoatsLabel);
            this.Controls.Add(this.paintPriceTxtBox);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.sqftTxtBox);
            this.Controls.Add(this.sqftWallLabel);
            this.Name = "programOneForm";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqftWallLabel;
        private System.Windows.Forms.TextBox sqftTxtBox;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.TextBox paintPriceTxtBox;
        private System.Windows.Forms.Label numberCoatsLabel;
        private System.Windows.Forms.TextBox numberCoatsTxtBox;
        private System.Windows.Forms.Label totalSqftLabel;
        private System.Windows.Forms.Label totalSqftOutputLabel;
        private System.Windows.Forms.Label gallonsRequiredLabel;
        private System.Windows.Forms.Label gallonsRequiredOutputLabel;
        private System.Windows.Forms.Label hoursRequiredLabel;
        private System.Windows.Forms.Label hoursRequiredOutputLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label paintCostOutputLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label laborCostOutputLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

