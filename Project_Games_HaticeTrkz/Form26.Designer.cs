﻿namespace Project_Games_HaticeTrkz
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUMBERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bODYPARTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button11 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUMBERSToolStripMenuItem,
            this.cOLORSToolStripMenuItem,
            this.bODYPARTSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUMBERSToolStripMenuItem
            // 
            this.nUMBERSToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUMBERSToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.nUMBERSToolStripMenuItem.Name = "nUMBERSToolStripMenuItem";
            this.nUMBERSToolStripMenuItem.Size = new System.Drawing.Size(172, 43);
            this.nUMBERSToolStripMenuItem.Text = "NUMBERS";
            this.nUMBERSToolStripMenuItem.Click += new System.EventHandler(this.nUMBERSToolStripMenuItem_Click);
            // 
            // cOLORSToolStripMenuItem
            // 
            this.cOLORSToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOLORSToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.cOLORSToolStripMenuItem.Name = "cOLORSToolStripMenuItem";
            this.cOLORSToolStripMenuItem.Size = new System.Drawing.Size(144, 43);
            this.cOLORSToolStripMenuItem.Text = "COLORS";
            this.cOLORSToolStripMenuItem.Click += new System.EventHandler(this.cOLORSToolStripMenuItem_Click);
            // 
            // bODYPARTSToolStripMenuItem
            // 
            this.bODYPARTSToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bODYPARTSToolStripMenuItem.ForeColor = System.Drawing.Color.RosyBrown;
            this.bODYPARTSToolStripMenuItem.Name = "bODYPARTSToolStripMenuItem";
            this.bODYPARTSToolStripMenuItem.Size = new System.Drawing.Size(168, 43);
            this.bODYPARTSToolStripMenuItem.Text = "ANIMALS";
            this.bODYPARTSToolStripMenuItem.Click += new System.EventHandler(this.bODYPARTSToolStripMenuItem_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(0, 632);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(145, 98);
            this.button11.TabIndex = 22;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 723);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form26";
            this.Text = "Form26";
            this.Load += new System.EventHandler(this.Form26_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUMBERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLORSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bODYPARTSToolStripMenuItem;
        private System.Windows.Forms.Button button11;
    }
}