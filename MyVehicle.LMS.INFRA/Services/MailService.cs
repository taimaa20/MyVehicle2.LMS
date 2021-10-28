using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Collections.Generic;
using System.Text;
//using System.Net.Mail;
using MailKit.Net.Smtp;

namespace MyVehicle.LMS.INFRA.Services
{
    public class MailService : IMailService
    {
        private readonly CORE.Data.MailSettings _mailSettings;
        public MailService(IOptions<CORE.Data.MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public bool SendEmailAsync(MailRequest mailRequest)
        {
            MimeMessage message = new MimeMessage();



            MailboxAddress from = new MailboxAddress("Jordan Islamic Bank", "thuraiasaleh95@gmail.com");
            message.From.Add(from);



            MailboxAddress to = new MailboxAddress("Taimaahamarneh1@gmail.com", "" + "Taimaahamarneh1@gmail.com" + "");
            message.To.Add(to);



            message.Subject = "Payment";


            Random rnd = new Random();
            var code = rnd.Next(0000, 9999);
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h3>Hi " + "Taima" + " " + " , </h3>" +
            "<p>You are receiving this email because Your Payment Completed Successfully </p>" +
            
            "  Regards" +
            "<p>Jordan Islamic Bank</p>";
            message.Body = bodyBuilder.ToMessageBody();



            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp.gmail.com", 587, false);
                clinte.Authenticate("thuriasaleh95@gmail.com", "**************");



                clinte.Send(message);
                clinte.Disconnect(true);



            }
            return true;
        }

    }
}
