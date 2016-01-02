using System;
using MailKit.Net.Smtp;
using MimeKit;

namespace MNKINO.Services
{
    public class StmpMailService : IMailService
    {
        public bool SendMail(string from, string replyTo, string body)
        {
            if (true)
            {
                var email = new SmtpClient();
                var msg = new MimeMessage();
                var address = new MailboxAddress("MNKINO", "mnkino@gmail.com");

                msg.To.Add(address);
                msg.From.Add(address);
                msg.Subject = $"MNKINO Website message from {from}";
                msg.Body = new TextPart("plain")
                {
                    Text = body
                };
                msg.ReplyTo.Add(new MailboxAddress(from,replyTo));

                try
                {
                    email.Send(msg);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    email.Dispose();
                }
            }
        }
    }
}

