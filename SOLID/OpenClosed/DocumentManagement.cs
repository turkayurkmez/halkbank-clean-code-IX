using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    //public enum DocumentType
    //{
    //    ISO9001,
    //    ISO14001,
    //    ISO31000

    //}

    public interface DocumentType
    {
        public void RequestToDatabase();
       
    }

    public class ISO9001 : DocumentType
    {
        public void RequestToDatabase()
        {
            Console.WriteLine("ISO 9001 için gereken db'ye işlem yapıldı");
        }
    }

    public class ISO14001 : DocumentType
    {
        public void RequestToDatabase()
        {
            Console.WriteLine("ISO 14001 için gereken db'ye işlem yapıldı");
        }
    }

    public class ISO3100 : DocumentType
    {
        public void RequestToDatabase()
        {
            Console.WriteLine("ISO 31000 için gereken db'ye işlem yapıldı");
        }
    }

    public class ISO22000 : DocumentType
    {
        public void RequestToDatabase()
        {
            Console.WriteLine("ISO 22000 için gereken db'ye işlem yapıldı");
        }
    }
    public class Document
    {
        public DocumentType DocumentType { get; set; }
    }
    public class DocumentManagement
    {
        public Document Document { get; set; }
        public void CreateDocumentRequest()
        {
            //switch (Document.DocumentType)
            //{
            //    case DocumentType.ISO9001:
            //        Console.WriteLine("ISO 9001 için gereken db'ye işlem yapıldı");
            //        break;
            //    case DocumentType.ISO14001:
            //        Console.WriteLine("ISO 14001 için gereken db'ye işlem yapıldı");

            //        break;
            //    case DocumentType.ISO31000:
            //        Console.WriteLine("ISO 31000 için gereken db'ye işlem yapıldı");

            //        break;
            //    default:
            //        break;
            //}
            Document.DocumentType.RequestToDatabase();
        }
    }
}
