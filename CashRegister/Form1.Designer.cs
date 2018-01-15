namespace CashRegister
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
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.lstOrderSummary = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblPizza = new System.Windows.Forms.Label();
            this.lblBurger = new System.Windows.Forms.Label();
            this.lblFries = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(53, 29);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(123, 23);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.Location = new System.Drawing.Point(53, 58);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(123, 23);
            this.btnBurger.TabIndex = 1;
            this.btnBurger.Text = "Burger";
            this.btnBurger.UseVisualStyleBackColor = true;
            // 
            // btnFries
            // 
            this.btnFries.Location = new System.Drawing.Point(53, 87);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(123, 23);
            this.btnFries.TabIndex = 2;
            this.btnFries.Text = "Fries";
            this.btnFries.UseVisualStyleBackColor = true;
            // 
            // lstOrderSummary
            // 
            this.lstOrderSummary.FormattingEnabled = true;
            this.lstOrderSummary.Location = new System.Drawing.Point(13, 151);
            this.lstOrderSummary.Name = "lstOrderSummary";
            this.lstOrderSummary.Size = new System.Drawing.Size(163, 160);
            this.lstOrderSummary.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(13, 13);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(74, 13);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Items for Sale:";
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(13, 34);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(34, 13);
            this.lblPizza.TabIndex = 6;
            this.lblPizza.Text = "$5.00";
            // 
            // lblBurger
            // 
            this.lblBurger.AutoSize = true;
            this.lblBurger.Location = new System.Drawing.Point(13, 63);
            this.lblBurger.Name = "lblBurger";
            this.lblBurger.Size = new System.Drawing.Size(34, 13);
            this.lblBurger.TabIndex = 7;
            this.lblBurger.Text = "$5.00";
            // 
            // lblFries
            // 
            this.lblFries.AutoSize = true;
            this.lblFries.Location = new System.Drawing.Point(13, 92);
            this.lblFries.Name = "lblFries";
            this.lblFries.Size = new System.Drawing.Size(34, 13);
            this.lblFries.TabIndex = 8;
            this.lblFries.Text = "$2.00";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(89, 125);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(87, 20);
            this.txtAmountPaid.TabIndex = 9;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(13, 128);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(70, 13);
            this.lblAmountPaid.TabIndex = 10;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 360);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.lblBurger);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOrderSummary);
            this.Controls.Add(this.btnFries);
            this.Controls.Add(this.btnBurger);
            this.Controls.Add(this.btnPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.ListBox lstOrderSummary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.Label lblBurger;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblAmountPaid;
    }
}

