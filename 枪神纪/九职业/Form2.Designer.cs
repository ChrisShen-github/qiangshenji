﻿namespace 枪神纪.九职业
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.自动背刺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动攻击ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动背刺ToolStripMenuItem,
            this.自动攻击ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // 自动背刺ToolStripMenuItem
            // 
            this.自动背刺ToolStripMenuItem.CheckOnClick = true;
            this.自动背刺ToolStripMenuItem.Name = "自动背刺ToolStripMenuItem";
            this.自动背刺ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.自动背刺ToolStripMenuItem.Text = "自动攻击";
            // 
            // 自动攻击ToolStripMenuItem
            // 
            this.自动攻击ToolStripMenuItem.CheckOnClick = true;
            this.自动攻击ToolStripMenuItem.Name = "自动攻击ToolStripMenuItem";
            this.自动攻击ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.自动攻击ToolStripMenuItem.Text = "自动催化";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 自动背刺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动攻击ToolStripMenuItem;
    }
}