using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TestAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var message = new MailMessage();

            // message.To.Add(new MailAddress(_savingIdeaConfiguration.ToEmailId1));

           

            message.To.Add(new MailAddress("Id"));
          

            message.From = new MailAddress("Id");

            //message.Bcc.Add(new MailAddress(_savingIdeaConfiguration.FromEmailId));
            message.Subject = "Invoice Approval Message";
            
            var html = System.IO.File.ReadAllText(@"C:\Users\garima jain\source\repos\WebApiHandson\TestAction\Card.html");
            message.Body = html;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.office365.com";
                smtp.Port = 587;
                //configure your mail id and password
                smtp.Credentials = new System.Net.NetworkCredential("Id,Pass");//Configure your mail ID and Password for testing
               
                smtp.EnableSsl = true;
                smtp.Send(message);
                Task.FromResult(0);
                Console.WriteLine("Message Successfully Sent");
                Console.ReadLine();
            }
        }
    }
}
