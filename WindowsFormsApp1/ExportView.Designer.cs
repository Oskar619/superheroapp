﻿namespace WindowsFormsApp1
{
    partial class ExportView
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
            this.txtExportData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtExportData
            // 
            this.txtExportData.Location = new System.Drawing.Point(12, 12);
            this.txtExportData.Name = "txtExportData";
            this.txtExportData.Size = new System.Drawing.Size(981, 521);
            this.txtExportData.TabIndex = 0;
            this.txtExportData.Text = "";
            // 
            // ExportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 545);
            this.Controls.Add(this.txtExportData);
            this.Name = "ExportView";
            this.Text = "Export View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtExportData;
    }
}