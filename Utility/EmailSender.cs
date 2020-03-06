using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using System.Security.Authentication;
using Newtonsoft.Json;

namespace Utility
{
    public class EmailSender
    {

        private string smtpEmail = "noreply.bhubanshrestha@gmail.com";

        public async Task SendEmailAsync(string AppName, string regKey, object schoolInfo)
        {
            try
            {
                string info = JsonConvert.SerializeObject(schoolInfo, Formatting.Indented);
                string htmlMessage = String.Format("<b>{0}</b> - Registered with key:{1}{1} {2}{1}{1} School Info: {1} {3}", AppName, Environment.NewLine, regKey, info);
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress("Bhuban Shrestha", smtpEmail));

                mimeMessage.To.Add(new MailboxAddress("bhubanshrestha12@gmail.com"));

                mimeMessage.Subject = AppName + " - Application Registered";

                mimeMessage.Body = new TextPart("html")
                {
                    Text = htmlMessage
                };

                using (var client = new SmtpClient())
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
                    await client.ConnectAsync("smtp.gmail.com", 465, true);

                    // Note: only needed if the SMTP server requires authentication
                    await client.AuthenticateAsync(smtpEmail, "uzocgyeklbcaewmx");

                    await client.SendAsync(mimeMessage);

                    await client.DisconnectAsync(true);
                }

            }
            catch (Exception ex)
            {
                // TODO: handle exception
                //throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
