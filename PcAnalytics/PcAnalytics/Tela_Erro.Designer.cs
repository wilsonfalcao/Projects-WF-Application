namespace PcAnalytics
{
    partial class Tela_Erro
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
            this.Text_Erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Text_Erro
            // 
            this.Text_Erro.AutoSize = true;
            this.Text_Erro.Location = new System.Drawing.Point(12, 9);
            this.Text_Erro.Name = "Text_Erro";
            this.Text_Erro.Size = new System.Drawing.Size(35, 13);
            this.Text_Erro.TabIndex = 0;
            this.Text_Erro.Text = "label1";
            // 
            // Tela_Erro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 94);
            this.Controls.Add(this.Text_Erro);
            this.Location = new System.Drawing.Point(945, 692);
            this.Name = "Tela_Erro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tela_Erro";
            this.Load += new System.EventHandler(this.Tela_Erro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_Erro;
    }
}