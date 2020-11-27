namespace Cash_Register
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
            this.receiptBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.beverageBox = new System.Windows.Forms.TextBox();
            this.sandwichBox = new System.Windows.Forms.TextBox();
            this.sidesaladBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.subtotalText = new System.Windows.Forms.Label();
            this.totalTax = new System.Windows.Forms.Label();
            this.taxText = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.Label();
            this.foodBox = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // receiptBox
            // 
            this.receiptBox.Location = new System.Drawing.Point(452, 21);
            this.receiptBox.Multiline = true;
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(263, 348);
            this.receiptBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mixage Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number Of Beverages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mixage Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Side Salads";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mixage Bk BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number Of Sandwiches";
            // 
            // beverageBox
            // 
            this.beverageBox.Location = new System.Drawing.Point(327, 75);
            this.beverageBox.Name = "beverageBox";
            this.beverageBox.Size = new System.Drawing.Size(29, 20);
            this.beverageBox.TabIndex = 6;
            this.beverageBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // sandwichBox
            // 
            this.sandwichBox.Location = new System.Drawing.Point(327, 109);
            this.sandwichBox.Name = "sandwichBox";
            this.sandwichBox.Size = new System.Drawing.Size(29, 20);
            this.sandwichBox.TabIndex = 7;
            // 
            // sidesaladBox
            // 
            this.sidesaladBox.Location = new System.Drawing.Point(327, 150);
            this.sidesaladBox.Name = "sidesaladBox";
            this.sidesaladBox.Size = new System.Drawing.Size(29, 20);
            this.sidesaladBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("NewBskvll BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mattuccis Sandwhich Shop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mixage Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mixage Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mixage Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sub Total:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(41, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(364, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mixage Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tendered:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(90, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Calculate Change";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mixage Bk BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Change:";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(327, 320);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(29, 20);
            this.tenderedBox.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "Print Receipt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // subtotalText
            // 
            this.subtotalText.AutoSize = true;
            this.subtotalText.Location = new System.Drawing.Point(315, 226);
            this.subtotalText.Name = "subtotalText";
            this.subtotalText.Size = new System.Drawing.Size(0, 13);
            this.subtotalText.TabIndex = 24;
            // 
            // totalTax
            // 
            this.totalTax.AutoSize = true;
            this.totalTax.Location = new System.Drawing.Point(315, 262);
            this.totalTax.Name = "totalTax";
            this.totalTax.Size = new System.Drawing.Size(0, 13);
            this.totalTax.TabIndex = 25;
            // 
            // taxText
            // 
            this.taxText.AutoSize = true;
            this.taxText.Location = new System.Drawing.Point(315, 244);
            this.taxText.Name = "taxText";
            this.taxText.Size = new System.Drawing.Size(0, 13);
            this.taxText.TabIndex = 26;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(315, 392);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 13);
            this.changeLabel.TabIndex = 27;
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.BackColor = System.Drawing.SystemColors.Control;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(475, 39);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(215, 20);
            this.titleBox.TabIndex = 28;
            this.titleBox.Text = "Mattuccis Sandwich Shop";
            this.titleBox.Visible = false;
            // 
            // dateBox
            // 
            this.dateBox.AutoSize = true;
            this.dateBox.BackColor = System.Drawing.SystemColors.Control;
            this.dateBox.Location = new System.Drawing.Point(476, 84);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(101, 13);
            this.dateBox.TabIndex = 29;
            this.dateBox.Text = "November 26, 2020";
            this.dateBox.Visible = false;
            // 
            // orderBox
            // 
            this.orderBox.AutoSize = true;
            this.orderBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderBox.Location = new System.Drawing.Point(476, 71);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(94, 13);
            this.orderBox.TabIndex = 30;
            this.orderBox.Text = "Order Number 378";
            this.orderBox.Visible = false;
            // 
            // foodBox
            // 
            this.foodBox.AutoSize = true;
            this.foodBox.BackColor = System.Drawing.SystemColors.Control;
            this.foodBox.Location = new System.Drawing.Point(476, 119);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(41, 13);
            this.foodBox.TabIndex = 31;
            this.foodBox.Text = "label10";
            this.foodBox.Visible = false;
            // 
            // numberBox
            // 
            this.numberBox.AutoSize = true;
            this.numberBox.BackColor = System.Drawing.SystemColors.Control;
            this.numberBox.Location = new System.Drawing.Point(649, 119);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(41, 13);
            this.numberBox.TabIndex = 32;
            this.numberBox.Text = "label10";
            this.numberBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.foodBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.taxText);
            this.Controls.Add(this.totalTax);
            this.Controls.Add(this.subtotalText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sidesaladBox);
            this.Controls.Add(this.sandwichBox);
            this.Controls.Add(this.beverageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receiptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox beverageBox;
        private System.Windows.Forms.TextBox sandwichBox;
        private System.Windows.Forms.TextBox sidesaladBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label subtotalText;
        private System.Windows.Forms.Label totalTax;
        private System.Windows.Forms.Label taxText;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label titleBox;
        private System.Windows.Forms.Label dateBox;
        private System.Windows.Forms.Label orderBox;
        private System.Windows.Forms.Label foodBox;
        private System.Windows.Forms.Label numberBox;
    }
}

