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

            //message.To.Add(new MailAddress("shubh.priyam@celebaltech.com"));
            //message.To.Add(new MailAddress("somil.vijay@celebaltech.com"));
            //message.To.Add(new MailAddress("oindrilla.sharma@celebaltech.com"));
            //message.To.Add(new MailAddress("prakhar.birla@celebaltech.com"));

            message.To.Add(new MailAddress("shubh.priyam@celebaltech.com"));
            message.To.Add(new MailAddress("garima.jain@celebaltech.com"));

            message.From = new MailAddress("garima.jain@celebaltech.com");

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
                smtp.Credentials = new System.Net.NetworkCredential("garima.jain@celebaltech.com", "Celebal@123");//Configure your mail ID and Password for testing
                //smtp.Credentials = new System.Net.NetworkCredential("MITTKU-CONT", "mahindra@1234", "mahindra");
                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(message);
                Task.FromResult(0);
                Console.WriteLine("Message Successfully Sent");
                Console.ReadLine();
            }
        }
    }
}
