﻿namespace JoesAutomotiveImprovedUgly
{
    partial class Parts
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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPartAva = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRecent = new System.Windows.Forms.TextBox();
            this.addButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tempListBox = new System.Windows.Forms.ListBox();
            this.homeButton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(152, 23);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // listBoxPartAva
            // 
            this.listBoxPartAva.FormattingEnabled = true;
            this.listBoxPartAva.Location = new System.Drawing.Point(27, 86);
            this.listBoxPartAva.Name = "listBoxPartAva";
            this.listBoxPartAva.Size = new System.Drawing.Size(164, 173);
            this.listBoxPartAva.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts available:";
            // 
            // txtBoxRecent
            // 
            this.txtBoxRecent.Location = new System.Drawing.Point(234, 86);
            this.txtBoxRecent.Name = "txtBoxRecent";
            this.txtBoxRecent.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRecent.TabIndex = 4;
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(251, 112);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(69, 27);
            this.addButton2.TabIndex = 5;
            this.addButton2.Text = "Add";
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notes:";
            // 
            // tempListBox
            // 
            this.tempListBox.FormattingEnabled = true;
            this.tempListBox.Location = new System.Drawing.Point(225, 164);
            this.tempListBox.Name = "tempListBox";
            this.tempListBox.Size = new System.Drawing.Size(120, 95);
            this.tempListBox.TabIndex = 7;
            // 
            // homeButton2
            // 
            this.homeButton2.Location = new System.Drawing.Point(167, 278);
            this.homeButton2.Name = "homeButton2";
            this.homeButton2.Size = new System.Drawing.Size(85, 28);
            this.homeButton2.TabIndex = 8;
            this.homeButton2.Text = "Home";
            this.homeButton2.UseVisualStyleBackColor = true;
            this.homeButton2.Click += new System.EventHandler(this.homeButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recent Purchases:";
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.homeButton2);
            this.Controls.Add(this.tempListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.txtBoxRecent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPartAva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSearch);
            this.Name = "Parts";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPartAva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRecent;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tempListBox;
        private System.Windows.Forms.Button homeButton2;
        private System.Windows.Forms.Label label4;
    }
}