namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExportData
            // 
            this.txtExportData.Location = new System.Drawing.Point(12, 12);
            this.txtExportData.Name = "txtExportData";
            this.txtExportData.Size = new System.Drawing.Size(981, 482);
            this.txtExportData.TabIndex = 0;
            this.txtExportData.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save as file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtExportData);
            this.Name = "ExportView";
            this.Text = "Export View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtExportData;
        private System.Windows.Forms.Button button1;
    }
}