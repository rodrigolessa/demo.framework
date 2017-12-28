using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.frm.infrastructure.Email
{
    public interface IEmailService
    {
        IEmailService SendMail(string subject, string body, string emailFrom, string emailTo, bool htmlBody);
        IEmailService SendMailWithErrors(string stackTrace, string emailTo = "erros@teste.com.br");
    }
}