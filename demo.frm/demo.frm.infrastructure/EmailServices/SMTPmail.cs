using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.EmailServices
{
    public partial class SMTPmail : IEmailService
    {
        public IEmailService SendMail(string subject, string body, string emailFrom, string emailTo, bool htmlBody)
        {
            var mailSMTP = new SmtpClient();
            var mailMessage = new MailMessage()
            {
                From = new MailAddress("padrao@teste.com.br"),
                Subject = subject,
                IsBodyHtml = htmlBody,
                Body = body
            };

            mailMessage.To.Add(emailTo);

            mailSMTP.Send(mailMessage);

            return this;
        }

        public IEmailService SendMailWithErrors(string stackTrace, string emailTo = "erros@teste.com.br")
        {
            return SendMail("Exception raised", stackTrace, "padrao@teste.com.br", emailTo, true);
        }
    }
}
