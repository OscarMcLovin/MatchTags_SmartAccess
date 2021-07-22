
namespace MatchTags_SmartAccess.Forms
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ADMIN = new System.Windows.Forms.ToolStripMenuItem();
            this.AccesoVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ADMIN,
            this.AccesoVehiculos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 96);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ADMIN
            // 
            this.ADMIN.ForeColor = System.Drawing.Color.White;
            this.ADMIN.Image = global::MatchTags_SmartAccess.Properties.Resources.barrio1;
            this.ADMIN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(134, 92);
            this.ADMIN.Text = "FRACCIONAMIENTOS";
            this.ADMIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ADMIN.Click += new System.EventHandler(this.ADMIN_Click);
            // 
            // AccesoVehiculos
            // 
            this.AccesoVehiculos.ForeColor = System.Drawing.Color.White;
            this.AccesoVehiculos.Image = global::MatchTags_SmartAccess.Properties.Resources.rfid;
            this.AccesoVehiculos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccesoVehiculos.Name = "AccesoVehiculos";
            this.AccesoVehiculos.Size = new System.Drawing.Size(147, 92);
            this.AccesoVehiculos.Text = "ADMINISTRACIÓN TAGS";
            this.AccesoVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AccesoVehiculos.Click += new System.EventHandler(this.AccesoVehiculos_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::MatchTags_SmartAccess.Properties.Resources.seguridad;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(722, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 78);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ADMIN;
        private System.Windows.Forms.ToolStripMenuItem AccesoVehiculos;
        private System.Windows.Forms.Button button1;
    }
}