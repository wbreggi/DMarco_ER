namespace DMarco_ER_Solution
{
    partial class frmEnviaRecado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviaRecado));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cboEnviarPara = new System.Windows.Forms.ComboBox();
            txtMens = new System.Windows.Forms.TextBox();
            rtxtRecado = new System.Windows.Forms.RichTextBox();
            rjbSair = new CustomControls.RJControls.RJButton();
            rjbEnviar = new CustomControls.RJControls.RJButton();
            rjbLimpar = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(565, 37);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gold;
            label1.Location = new System.Drawing.Point(179, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "* Anote o Recado *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.MediumBlue;
            label2.Location = new System.Drawing.Point(2, 413);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Enviar para :";
            // 
            // cboEnviarPara
            // 
            cboEnviarPara.BackColor = System.Drawing.Color.CornflowerBlue;
            cboEnviarPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboEnviarPara.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboEnviarPara.ForeColor = System.Drawing.Color.Navy;
            cboEnviarPara.FormattingEnabled = true;
            cboEnviarPara.Location = new System.Drawing.Point(101, 410);
            cboEnviarPara.Name = "cboEnviarPara";
            cboEnviarPara.Size = new System.Drawing.Size(277, 28);
            cboEnviarPara.TabIndex = 5;
            // 
            // txtMens
            // 
            txtMens.BackColor = System.Drawing.Color.CornflowerBlue;
            txtMens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMens.Location = new System.Drawing.Point(103, 366);
            txtMens.Name = "txtMens";
            txtMens.ReadOnly = true;
            txtMens.Size = new System.Drawing.Size(459, 22);
            txtMens.TabIndex = 12;
            // 
            // rtxtRecado
            // 
            rtxtRecado.BackColor = System.Drawing.Color.Black;
            rtxtRecado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtxtRecado.ForeColor = System.Drawing.Color.White;
            rtxtRecado.Location = new System.Drawing.Point(3, 43);
            rtxtRecado.MaxLength = 2000;
            rtxtRecado.Name = "rtxtRecado";
            rtxtRecado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            rtxtRecado.Size = new System.Drawing.Size(564, 315);
            rtxtRecado.TabIndex = 13;
            rtxtRecado.Text = "";
            // 
            // rjbSair
            // 
            rjbSair.BackColor = System.Drawing.Color.MediumBlue;
            rjbSair.BackgroundColor = System.Drawing.Color.MediumBlue;
            rjbSair.BorderColor = System.Drawing.Color.MediumBlue;
            rjbSair.BorderRadius = 5;
            rjbSair.BorderSize = 0;
            rjbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            rjbSair.FlatAppearance.BorderSize = 0;
            rjbSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjbSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbSair.ForeColor = System.Drawing.Color.Gold;
            rjbSair.Location = new System.Drawing.Point(498, 361);
            rjbSair.Name = "rjbSair";
            rjbSair.Size = new System.Drawing.Size(63, 25);
            rjbSair.TabIndex = 14;
            rjbSair.Text = "Sair";
            rjbSair.TextColor = System.Drawing.Color.Gold;
            rjbSair.UseVisualStyleBackColor = false;
            rjbSair.Click += rjbSair_Click;
            // 
            // rjbEnviar
            // 
            rjbEnviar.BackColor = System.Drawing.Color.MediumBlue;
            rjbEnviar.BackgroundColor = System.Drawing.Color.MediumBlue;
            rjbEnviar.BorderColor = System.Drawing.Color.MediumBlue;
            rjbEnviar.BorderRadius = 5;
            rjbEnviar.BorderSize = 0;
            rjbEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            rjbEnviar.FlatAppearance.BorderSize = 0;
            rjbEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjbEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbEnviar.ForeColor = System.Drawing.Color.Gold;
            rjbEnviar.Location = new System.Drawing.Point(385, 409);
            rjbEnviar.Name = "rjbEnviar";
            rjbEnviar.Size = new System.Drawing.Size(59, 30);
            rjbEnviar.TabIndex = 15;
            rjbEnviar.Text = "Enviar";
            rjbEnviar.TextColor = System.Drawing.Color.Gold;
            rjbEnviar.UseVisualStyleBackColor = false;
            rjbEnviar.Click += rjbEnviar_Click;
            // 
            // rjbLimpar
            // 
            rjbLimpar.BackColor = System.Drawing.Color.MediumBlue;
            rjbLimpar.BackgroundColor = System.Drawing.Color.MediumBlue;
            rjbLimpar.BorderColor = System.Drawing.Color.MediumBlue;
            rjbLimpar.BorderRadius = 5;
            rjbLimpar.BorderSize = 0;
            rjbLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            rjbLimpar.FlatAppearance.BorderSize = 0;
            rjbLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjbLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbLimpar.ForeColor = System.Drawing.Color.Gold;
            rjbLimpar.Location = new System.Drawing.Point(6, 360);
            rjbLimpar.Name = "rjbLimpar";
            rjbLimpar.Size = new System.Drawing.Size(63, 25);
            rjbLimpar.TabIndex = 16;
            rjbLimpar.Text = "Limpar";
            rjbLimpar.TextColor = System.Drawing.Color.Gold;
            rjbLimpar.UseVisualStyleBackColor = false;
            rjbLimpar.Click += rjbLimpar_Click;
            // 
            // frmEnviaRecado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(569, 455);
            Controls.Add(rjbLimpar);
            Controls.Add(rjbEnviar);
            Controls.Add(rjbSair);
            Controls.Add(rtxtRecado);
            Controls.Add(txtMens);
            Controls.Add(cboEnviarPara);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = System.Drawing.SystemColors.MenuHighlight;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEnviaRecado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "D'Marco Contábil - Envia Recado";
            Activated += frmEnviaRecado_Activated;
            FormClosing += frmEnviaRecado_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEnviarPara;
        private CustomControls.RJControls.RJButton rjbSair;
        private System.Windows.Forms.TextBox txtMens;
        private System.Windows.Forms.RichTextBox rtxtRecado;
        private CustomControls.RJControls.RJButton rjbEnviar;
        private CustomControls.RJControls.RJButton rjbLimpar;
    }
}