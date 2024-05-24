// See https://aka.ms/new-console-template for more information
using OpenClosed;


Console.WriteLine("Hello, World!");
//Bir nesne, ........gelişime............ AÇIK .......değişime.... KAPALI olmalı!

Document document = new OpenClosed.Document { DocumentType = new ISO22000() };
DocumentManagement documentManagement = new DocumentManagement() { Document =document};
documentManagement.CreateDocumentRequest();