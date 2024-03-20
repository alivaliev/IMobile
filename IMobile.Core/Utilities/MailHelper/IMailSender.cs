using System;

namespace IMobile.Core.Utilities.MailHelper
{
    public interface IMailSender
    {
        bool SendMail(string mailAddress, string message, bool bodyHtml);
    }
}

