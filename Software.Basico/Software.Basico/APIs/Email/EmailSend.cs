using Software.Basico.Properties;
using System;
using System.Net;
using System.Net.Mail;

namespace Software.Basico.APIs.Email
{
    class EmailSend
    {
        public void EnviarEmail(EmailDTO dto)
        {
            var smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential(dto.RemetenteEmail, dto.RemetenteSenha);

            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(dto.RemetenteEmail, dto.RemetenteNome);
            mail.To.Add(new MailAddress(dto.DestinatarioEmail, dto.DestinatarioNome));
            mail.Subject = dto.Assunto;
            mail.Body = Resources.htmlEmail;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                throw new ArgumentException($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }
    }
}
