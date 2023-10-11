namespace DMarco_ER_Solution
{
    partial class frmEnviaRecado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviaRecado));
            txtRecado = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cboEnviarPara = new System.Windows.Forms.ComboBox();
            rjbEnviar = new CustomControls.RJControls.RJButton();
            rjbSair = new CustomControls.RJControls.RJButton();
            txtMens = new System.Windows.Forms.TextBox();
            rjbLimpar = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRecado
            // 
            txtRecado.BackColor = System.Drawing.Color.DarkBlue;
            txtRecado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtRecado.ForeColor = System.Drawing.Color.White;
            txtRecado.Location = new System.Drawing.Point(2, 42);
            txtRecado.MaxLength = 2000;
            txtRecado.Multiline = true;
            txtRecado.Name = "txtRecado";
            txtRecado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtRecado.Size = new System.Drawing.Size(565, 321);
            txtRecado.TabIndex = 1;
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
            label2.ForeColor = System.Drawing.Color.Indigo;
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
            rjbEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbEnviar.ForeColor = System.Drawing.Color.Gold;
            rjbEnviar.Location = new System.Drawing.Point(387, 408);
            rjbEnviar.Name = "rjbEnviar";
            rjbEnviar.Size = new System.Drawing.Size(70, 30);
            rjbEnviar.TabIndex = 9;
            rjbEnviar.Text = "Enviar";
            rjbEnviar.TextColor = System.Drawing.Color.Gold;
            rjbEnviar.UseVisualStyleBackColor = false;
            rjbEnviar.Click += rjbEnviar_Click;
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
            rjbSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbSair.ForeColor = System.Drawing.Color.White;
            rjbSair.Location = new System.Drawing.Point(470, 408);
            rjbSair.Name = "rjbSair";
            rjbSair.Size = new System.Drawing.Size(66, 30);
            rjbSair.TabIndex = 10;
            rjbSair.Text = "Sair";
            rjbSair.TextColor = System.Drawing.Color.White;
            rjbSair.UseVisualStyleBackColor = false;
            rjbSair.Click += rjbSair_Click;
            // 
            // txtMens
            // 
            txtMens.BackColor = System.Drawing.Color.CornflowerBlue;
            txtMens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMens.Location = new System.Drawing.Point(171, 372);
            txtMens.Name = "txtMens";
            txtMens.ReadOnly = true;
            txtMens.Size = new System.Drawing.Size(391, 22);
            txtMens.TabIndex = 12;
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
            rjbLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rjbLimpar.ForeColor = System.Drawing.Color.Gold;
            rjbLimpar.Location = new System.Drawing.Point(1, 367);
            rjbLimpar.Name = "rjbLimpar";
            rjbLimpar.Size = new System.Drawing.Size(123, 30);
            rjbLimpar.TabIndex = 13;
            rjbLimpar.Text = "Limpar Recado";
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
            Controls.Add(txtMens);
            Controls.Add(rjbSair);
            Controls.Add(rjbEnviar);
            Controls.Add(cboEnviarPara);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtRecado);
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
        private System.Windows.Forms.TextBox txtRecado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEnviarPara;
        private CustomControls.RJControls.RJButton rjbEnviar;
        private CustomControls.RJControls.RJButton rjbSair;
        private System.Windows.Forms.TextBox txtMens;
        private CustomControls.RJControls.RJButton rjbLimpar;
    }
}