using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

using Newtonsoft.Json;
using DMarco_ER_Solution.Dtos;
using DMarco_ER_Solution.Serialization;
using System.Configuration;

namespace DMarco_ER_Solution;
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
        bool sit;

        sit = CarregarCboEnviarPara();
        if (!sit) return;
        this.rtxtRecado.Focus();
        return;
    }

    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    private void rjbEnviar_Click(object sender, EventArgs e)
    {
        StringBuilder msg = new StringBuilder();
        string destino = string.Empty;

        if (this.rtxtRecado.Text.Trim().Length == 0)
        {
            msg.Append("Nenhum recado foi anotado.Não há nada para enviar.");
            MessageBox.Show(msg.ToString(), "* Mensagem do [Envia Recado] *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.rtxtRecado.Focus();
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
        this.rtxtRecado.Refresh();

        this.rjbEnviar.Enabled = false;
        this.rjbSair.Enabled = false;
        this.rjbLimpar.Enabled = false;

        SmtpClient smtpClient = new SmtpClient("smtp-relay.sendinblue.com", 587);
        smtpClient.EnableSsl = true;
        smtpClient.Timeout = 60 * 60 * 30;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential("wagner.breggi@gmail.com", "8OEzAYdcCGpqSUVh");

        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress("recados.dmarco@gmail.com", "D'Marco Contábil-Recado");
        mailMessage.Subject = "*D'Marco Contábil-Recado: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "h" + " (Não re-envie essa mensagem)";
        mailMessage.IsBodyHtml = true;
        mailMessage.Priority = MailPriority.Normal;

        this.rtxtRecado.Text = this.rtxtRecado.Text.Replace("\n", "\r\n");
        mailMessage.Body = this.rtxtRecado.Text;

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
        this.rtxtRecado.Focus();
        return;
    }

    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    private void rjbLimpar_Click(object sender, EventArgs e)
    {
        this.rtxtRecado.Text = String.Empty;
        this.rtxtRecado.Focus();
        return;
    }

    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    private void frmEnviaRecado_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (this.rtxtRecado.Text.Trim().Length > 0)
        {
            string msg = "Foi anotado um recado.Você quer sair sem envia-lo ?";
            DialogResult result = MessageBox.Show(msg, "* Mensagem do Envia Recado *", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
            this.rtxtRecado.Focus();
            return;
        }
        return;
    }

    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    private bool CarregarCboEnviarPara()
    {
        string pastaEmails = ConfigurationManager.AppSettings["emails"] ?? String.Empty;

        if (!File.Exists(pastaEmails + "func_email.json"))
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("Arquivo de parâmetros [func_email.json] não foi encontrado em \n");
            msg.Append(@"C:\MyFolders\dev\VS2022\DMarco_ER\DMarco_ER_Solution\func_email.json" + "\n");
            msg.Append("Impossível continuar.");
            MessageBox.Show(msg.ToString(), "* Mensagem do Envia Recado *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        var dados = File.ReadAllText(pastaEmails + "func_email.json");

        IList<Serialization.FuncEmail> emCasoDeNullLst = new List<Serialization.FuncEmail>();
        IList<Serialization.FuncEmail> funcEmailLst = JsonConvert.DeserializeObject<List<Serialization.FuncEmail>>(dados) ?? emCasoDeNullLst;

        cboEnviarPara.DataSource = funcEmailLst;
        cboEnviarPara.DisplayMember = "func";
        cboEnviarPara.ValueMember = "email";
        cboEnviarPara.SelectedIndex = 0;
        return true;
    }

    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    private void rjbSair_Click(object sender, EventArgs e)
    {
        this.Close();
        return;
    }
}
