
namespace MatchTags_SmartAccess.Forms
{
    partial class Fraccionamientos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmboxFraccionamientos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = global::MatchTags_SmartAccess.Properties.Resources.error;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(167, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MatchTags_SmartAccess.Properties.Resources.plug;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(28, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmboxFraccionamientos
            // 
            this.cmboxFraccionamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFraccionamientos.FormattingEnabled = true;
            this.cmboxFraccionamientos.Location = new System.Drawing.Point(28, 55);
            this.cmboxFraccionamientos.Name = "cmboxFraccionamientos";
            this.cmboxFraccionamientos.Size = new System.Drawing.Size(255, 21);
            this.cmboxFraccionamientos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fraccionamiento";
            // 
            // Fraccionamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(311, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxFraccionamientos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fraccionamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraccionamientos";
            this.Load += new System.EventHandler(this.Fraccionamientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmboxFraccionamientos;
        private System.Windows.Forms.Label label1;
    }
}