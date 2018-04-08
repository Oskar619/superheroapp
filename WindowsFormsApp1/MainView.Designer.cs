namespace WindowsFormsApp1
{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoadedSuperHeroes = new System.Windows.Forms.ComboBox();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.profileGb = new System.Windows.Forms.GroupBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.lblPowers = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.lblProfilePicture = new System.Windows.Forms.Label();
            this.lbPowers = new System.Windows.Forms.ListBox();
            this.btnDeletePower = new System.Windows.Forms.Button();
            this.btnEditPower = new System.Windows.Forms.Button();
            this.btnAddPower = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.profileGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAssemblyToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadAssemblyToolStripMenuItem
            // 
            this.loadAssemblyToolStripMenuItem.Name = "loadAssemblyToolStripMenuItem";
            this.loadAssemblyToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.loadAssemblyToolStripMenuItem.Text = "Load Assembly";
            this.loadAssemblyToolStripMenuItem.Click += new System.EventHandler(this.LoadAssembly_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsXMLToolStripMenuItem,
            this.exportAsJSONToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAsXMLToolStripMenuItem
            // 
            this.exportAsXMLToolStripMenuItem.Name = "exportAsXMLToolStripMenuItem";
            this.exportAsXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsXMLToolStripMenuItem.Text = "Export as XML";
            this.exportAsXMLToolStripMenuItem.Click += new System.EventHandler(this.exportAsXMLToolStripMenuItem_Click);
            // 
            // exportAsJSONToolStripMenuItem
            // 
            this.exportAsJSONToolStripMenuItem.Name = "exportAsJSONToolStripMenuItem";
            this.exportAsJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsJSONToolStripMenuItem.Text = "Export as JSON";
            this.exportAsJSONToolStripMenuItem.Click += new System.EventHandler(this.exportAsJSONToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loaded Superheroes";
            // 
            // cbLoadedSuperHeroes
            // 
            this.cbLoadedSuperHeroes.FormattingEnabled = true;
            this.cbLoadedSuperHeroes.Location = new System.Drawing.Point(25, 69);
            this.cbLoadedSuperHeroes.Name = "cbLoadedSuperHeroes";
            this.cbLoadedSuperHeroes.Size = new System.Drawing.Size(278, 21);
            this.cbLoadedSuperHeroes.TabIndex = 2;
            this.cbLoadedSuperHeroes.SelectedIndexChanged += new System.EventHandler(this.cbLoadedSuperHeroes_SelectedIndexChanged);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(25, 123);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(278, 292);
            this.pbProfilePicture.TabIndex = 3;
            this.pbProfilePicture.TabStop = false;
            // 
            // profileGb
            // 
            this.profileGb.Controls.Add(this.btnAddPower);
            this.profileGb.Controls.Add(this.btnEditPower);
            this.profileGb.Controls.Add(this.btnDeletePower);
            this.profileGb.Controls.Add(this.lbPowers);
            this.profileGb.Controls.Add(this.txtDateOfBirth);
            this.profileGb.Controls.Add(this.txtRealName);
            this.profileGb.Controls.Add(this.lblPowers);
            this.profileGb.Controls.Add(this.lblDateOfBirth);
            this.profileGb.Controls.Add(this.lblRealName);
            this.profileGb.Location = new System.Drawing.Point(359, 123);
            this.profileGb.Name = "profileGb";
            this.profileGb.Size = new System.Drawing.Size(385, 292);
            this.profileGb.TabIndex = 4;
            this.profileGb.TabStop = false;
            this.profileGb.Text = "Profile";
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(25, 93);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(293, 20);
            this.txtDateOfBirth.TabIndex = 4;
            // 
            // txtRealName
            // 
            this.txtRealName.Enabled = false;
            this.txtRealName.Location = new System.Drawing.Point(25, 54);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(293, 20);
            this.txtRealName.TabIndex = 3;
            // 
            // lblPowers
            // 
            this.lblPowers.AutoSize = true;
            this.lblPowers.Location = new System.Drawing.Point(22, 116);
            this.lblPowers.Name = "lblPowers";
            this.lblPowers.Size = new System.Drawing.Size(45, 13);
            this.lblPowers.TabIndex = 2;
            this.lblPowers.Text = "Powers:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(22, 77);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 1;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(22, 37);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(63, 13);
            this.lblRealName.TabIndex = 0;
            this.lblRealName.Text = "Real Name:";
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.Location = new System.Drawing.Point(25, 104);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(43, 13);
            this.lblProfilePicture.TabIndex = 5;
            this.lblProfilePicture.Text = "Picture:";
            // 
            // lbPowers
            // 
            this.lbPowers.FormattingEnabled = true;
            this.lbPowers.Location = new System.Drawing.Point(25, 133);
            this.lbPowers.Name = "lbPowers";
            this.lbPowers.Size = new System.Drawing.Size(293, 147);
            this.lbPowers.TabIndex = 5;
            this.lbPowers.SelectedIndexChanged += new System.EventHandler(this.lbPowers_SelectedIndexChanged);
            // 
            // btnDeletePower
            // 
            this.btnDeletePower.Location = new System.Drawing.Point(324, 228);
            this.btnDeletePower.Name = "btnDeletePower";
            this.btnDeletePower.Size = new System.Drawing.Size(55, 32);
            this.btnDeletePower.TabIndex = 6;
            this.btnDeletePower.Text = "Delete";
            this.btnDeletePower.UseVisualStyleBackColor = true;
            this.btnDeletePower.Click += new System.EventHandler(this.btnDeletePower_Click);
            // 
            // btnEditPower
            // 
            this.btnEditPower.Location = new System.Drawing.Point(324, 190);
            this.btnEditPower.Name = "btnEditPower";
            this.btnEditPower.Size = new System.Drawing.Size(55, 32);
            this.btnEditPower.TabIndex = 7;
            this.btnEditPower.Text = "Edit";
            this.btnEditPower.UseVisualStyleBackColor = true;
            this.btnEditPower.Click += new System.EventHandler(this.btnEditPower_Click);
            // 
            // btnAddPower
            // 
            this.btnAddPower.Location = new System.Drawing.Point(324, 152);
            this.btnAddPower.Name = "btnAddPower";
            this.btnAddPower.Size = new System.Drawing.Size(55, 32);
            this.btnAddPower.TabIndex = 8;
            this.btnAddPower.Text = "Add";
            this.btnAddPower.UseVisualStyleBackColor = true;
            this.btnAddPower.Click += new System.EventHandler(this.btnAddPower_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProfilePicture);
            this.Controls.Add(this.profileGb);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.cbLoadedSuperHeroes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Superhero profile visor";
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.profileGb.ResumeLayout(false);
            this.profileGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadAssemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsJSONToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoadedSuperHeroes;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.GroupBox profileGb;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.Label lblPowers;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.Label lblProfilePicture;
        private System.Windows.Forms.Button btnAddPower;
        private System.Windows.Forms.Button btnEditPower;
        private System.Windows.Forms.Button btnDeletePower;
        private System.Windows.Forms.ListBox lbPowers;
    }
}

