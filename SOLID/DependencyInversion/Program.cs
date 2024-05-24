// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency: Bir eylemin başka bir nesneye "bağlı" olması. Bir makinenin çalışması bir nesneye bağlı olabilir.
 * Büyük sistem, küçüğe değil; küçük sistem büyüğe "aktarılıyor" olmalı.
 * 
 * Inversion: Tersine çevir. 
 * 
 * 
 */
MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();
Report report = new Report(whatsAppSender);
//report.MailSender = mailSender;
report.Send();

