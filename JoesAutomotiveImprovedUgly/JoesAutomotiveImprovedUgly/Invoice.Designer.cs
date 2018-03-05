namespace JoesAutomotiveImprovedUgly
{
    partial class Invoice
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
            this.partPurchListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPurch = new System.Windows.Forms.TextBox();
            this.addButton3 = new System.Windows.Forms.Button();
            this.clearButton3 = new System.Windows.Forms.Button();
            this.homeButton3 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partPurchListBox
            // 
            this.partPurchListBox.FormattingEnabled = true;
            this.partPurchListBox.Location = new System.Drawing.Point(24, 53);
            this.partPurchListBox.Name = "partPurchListBox";
            this.partPurchListBox.Size = new System.Drawing.Size(197, 225);
            this.partPurchListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purchases:";
            // 
            // txtBoxPurch
            // 
            this.txtBoxPurch.Location = new System.Drawing.Point(255, 64);
            this.txtBoxPurch.Name = "txtBoxPurch";
            this.txtBoxPurch.Size = new System.Drawing.Size(139, 20);
            this.txtBoxPurch.TabIndex = 2;
            // 
            // addButton3
            // 
            this.addButton3.Location = new System.Drawing.Point(237, 101);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(75, 23);
            this.addButton3.TabIndex = 3;
            this.addButton3.Text = "Add";
            this.addButton3.UseVisualStyleBackColor = true;
            this.addButton3.Click += new System.EventHandler(this.addButton3_Click);
            // 
            // clearButton3
            // 
            this.clearButton3.Location = new System.Drawing.Point(339, 101);
            this.clearButton3.Name = "clearButton3";
            this.clearButton3.Size = new System.Drawing.Size(75, 23);
            this.clearButton3.TabIndex = 4;
            this.clearButton3.Text = "Clear";
            this.clearButton3.UseVisualStyleBackColor = true;
            // 
            // homeButton3
            // 
            this.homeButton3.Location = new System.Drawing.Point(285, 130);
            this.homeButton3.Name = "homeButton3";
            this.homeButton3.Size = new System.Drawing.Size(75, 23);
            this.homeButton3.TabIndex = 5;
            this.homeButton3.Text = "Home";
            this.homeButton3.UseVisualStyleBackColor = true;
            this.homeButton3.Click += new System.EventHandler(this.homeButton3_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(285, 159);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 390);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.homeButton3);
            this.Controls.Add(this.clearButton3);
            this.Controls.Add(this.addButton3);
            this.Controls.Add(this.txtBoxPurch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partPurchListBox);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox partPurchListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPurch;
        private System.Windows.Forms.Button addButton3;
        private System.Windows.Forms.Button clearButton3;
        private System.Windows.Forms.Button homeButton3;
        private System.Windows.Forms.Button Save;
    }
}