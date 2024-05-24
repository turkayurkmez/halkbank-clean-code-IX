using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    
    public class Report
    {

        private readonly ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }

        //public MailSender MailSender { get; set; }

        public void Send()
        {
         
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail Gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp Gönderildi");
        }
    }
    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile Gönderildi");

        }
    }
}
