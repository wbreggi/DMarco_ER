using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

using DMarco_ER_Solution.Dtos;

namespace DMarco_ER_Solution
{
    public partial class frmEnviaRecado : Form
    {
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public frmEnviaRecado()
        {
            InitializeComponent();
            return;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void frmEnviaRecado_Activated(object sender, EventArgs e)
        {
            CarregarCboEnviarPara();
            this.txtRecado.Focus();
            return;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void rjbEnviar_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            string destino = string.Empty;

            if (this.txtRecado.Text.Trim().Length == 0)
            {
                msg.Append("Nenhum recado foi anotado.Não há nada para enviar.");
                MessageBox.Show(msg.ToString(), "* Mensagem do [Envia Recado] *", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtRecado.Focus();
                return;
            }

            if (cboEnviarPara.SelectedValue.ToString() == String.Empty)
            {
                msg.Clear();
                msg.Append("Não foi selecionado para quem enviar o recado.");
                MessageBox.Show(msg.ToString(), "* Mensagem do [Envia Recado] *", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cboEnviarPara.Focus();
                return;
            }

            this.txtMens.Text = "Aguarde.Enviando recado ...";
            this.txtRecado.Refresh();

            this.rjbEnviar.Enabled = false;
            this.rjbSair.Enabled = false;
            this.rjbLimpar.Enabled = false;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 60 * 60 * 30;
            smtpClient.UseDefaultCredentials = false;
            // smtpClient.Credentials = new NetworkCredential("wagner.breggi@gmail.com", "AE18791955");
            smtpClient.Credentials = new NetworkCredential("wagner.breggi@gmail.com", "eocnhdxhdufpxmfu");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("recados.dmarco@gmail.com", "D'Marco Contábil-Recado");
            mailMessage.Subject = "*D'Marco Contábil-Recado: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "h";
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.Normal;
            mailMessage.Body = this.txtRecado.Text;

            //...mailMessage.To.Add("wagner.breggi@gmail.com");
            //...mailMessage.To.Add("marco@dmarcontabil.com.br");
            destino = cboEnviarPara.SelectedValue.ToString() ?? String.Empty;
            mailMessage.To.Add(destino);

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                msg.Clear();
                msg.Append("Aviso de ocorrência de erro no envio do e-mail.\n");
                msg.Append(ex.Message + ".\n");
                msg.Append(ex.InnerException + ".\n");
                msg.Append(ex.Source + ".\n\n");
                msg.Append("Verifique se sua internet está on-line e re-envie\n");
                msg.Append("Se sua internet está on-line e mesmo assim, o Aviso de Ocorrência de Erro está sendo enviado, avise o resposável pelo sistema.\n");
                MessageBox.Show(msg.ToString(), "* Mensagem do [Envia Recado] *", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.rjbEnviar.Enabled = true;
                this.rjbSair.Enabled = true;
                this.rjbLimpar.Enabled = true;

                this.txtMens.Text = String.Empty;
                this.txtMens.Refresh();
                return;
            }

            this.txtMens.Text = String.Empty;
            this.txtMens.Refresh();

            msg.Clear();
            msg.Append("e-Mail enviado com sucesso!");
            MessageBox.Show(msg.ToString(), "* Mensagem do Envia Recado *", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.rjbEnviar.Enabled = true;
            this.rjbSair.Enabled = true;
            this.rjbLimpar.Enabled = true;
            this.txtRecado.Focus();

            // this.txtRecado.Text = String.Empty;
            // this.txtRecado.Focus();
            return;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void rjbLimpar_Click(object sender, EventArgs e)
        {
            this.txtRecado.Text = String.Empty;
            this.txtRecado.Focus();
            return;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void frmEnviaRecado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.txtRecado.Text.Trim().Length > 0)
            {
                string msg = "Foi anotado um recado.Você quer sair sem envia-lo ?";
                DialogResult result = MessageBox.Show(msg, "* Mensagem do Envia Recado *", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) e.Cancel = true;
                this.txtRecado.Focus();
                return;
            }
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void CarregarCboEnviarPara()
        {
            IList<FuncEmail> anosLst = new List<FuncEmail>
            {
                new FuncEmail {Func = "Selecione ...",EMail=""},
                new FuncEmail {Func = "Marco",EMail="marco@dmarcontabil.com.br"},
                new FuncEmail {Func = "Meire",EMail="fiscal@dmarcontabil.com.br"},
                new FuncEmail {Func = "Jaqueline",EMail="fiscal@dmarcontabil.com.br"},
                new FuncEmail {Func = "Luiz Claudio",EMail="contabil@dmarcontabil.com.br"},
                new FuncEmail {Func = "Paola",EMail="rh@dmarcontabil.com.br"}
            };

            cboEnviarPara.DataSource = anosLst;
            cboEnviarPara.DisplayMember = "Func";
            cboEnviarPara.ValueMember = "EMail";
            cboEnviarPara.SelectedIndex = 0;
            return;
        }

        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private void rjbSair_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

    }
}
