namespace projTeatroWF
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
            this.chkMeia = new System.Windows.Forms.CheckBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkMeia
            // 
            this.chkMeia.AutoSize = true;
            this.chkMeia.Location = new System.Drawing.Point(88, 3);
            this.chkMeia.Name = "chkMeia";
            this.chkMeia.Size = new System.Drawing.Size(89, 17);
            this.chkMeia.TabIndex = 0;
            this.chkMeia.Text = "Meia Entrada";
            this.chkMeia.UseVisualStyleBackColor = true;
            this.chkMeia.CheckedChanged += new System.EventHandler(this.chkMeia_CheckedChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(394, 329);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(70, 21);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 358);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.chkMeia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMeia;
        private System.Windows.Forms.Button btn_limpar;
    }
}

