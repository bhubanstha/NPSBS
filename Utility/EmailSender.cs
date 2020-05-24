using System;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using System.Security.Authentication;
using Newtonsoft.Json;
using System.IO;

namespace Utility
{
    public class EmailSender
    {

        private static string smtpEmail = "noreply.bhubanshrestha@gmail.com";

        public static async Task SendEmailAsync(string AppName, string regKey, object schoolInfo, string logoPath)
        {
            try
            {
                
                string info = JsonConvert.SerializeObject(schoolInfo, Formatting.Indented);
                string htmlMessage = String.Format("<div style='background-color: #ccc; padding: 5px;'> <p style='text-align: center;'><b>{0}</b> is installed in new computer.<br />{3}<br/><br/><br /><strong>Registration Key Used</strong>:</p> <p style='text-align: center;'>{1}</p> <p style='text-align: center;'>&nbsp;</p> <p style='text-align: center;'><strong>School Information</strong>:</p> <p style='text-align: center;'>{2}</p> </div>", AppName, regKey, info, new SystemInfo().ToString());
                var mimeMessage = new MimeMessage();

                mimeMessage.From.Add(new MailboxAddress("NPSBS Result Processing", smtpEmail));

                mimeMessage.To.Add(new MailboxAddress("bhubanshrestha12@gmail.com"));

                mimeMessage.Subject = "👀✨✨" + AppName + " - Application Registered";

                var bodyMessage = new TextPart("html")
                {
                    Text = htmlMessage                    
                };


                var att = new MimePart("image", "png")
                {
                    Content = new MimeContent(File.OpenRead(logoPath)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(logoPath)
                };

                var multipart = new Multipart("mixed");
                multipart.Add(att);
                multipart.Add(bodyMessage);
                mimeMessage.Body = multipart;


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
