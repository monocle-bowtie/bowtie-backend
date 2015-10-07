using SistAdmin.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SistAdmin_f4.Helper
{
	public class EmailHelper
	{
        public static void sendMailAlertJefe(Vendedor jefe, Vendedor emp)
		{
			string smtpServer = ConfigurationManager.AppSettings["SMTP_SERVER"];
			string smtpPort = ConfigurationManager.AppSettings["SMTP_PORT"];
			string smtpSsl = ConfigurationManager.AppSettings["SMTP_SSL"];
			string smtpUser = ConfigurationManager.AppSettings["SMTP_USER"];
			string smtpPassword = ConfigurationManager.AppSettings["SMTP_PASSWORD"];
			string sSenderName = ConfigurationManager.AppSettings["SMTP_SENDER_NAME"];
			string sSenderEmail = ConfigurationManager.AppSettings["SMTP_SENDER_EMAIL"];

			bool useSsl = smtpSsl != null && smtpSsl == "true";


			string sSubject = ConfigurationManager.AppSettings["MAIL_ALERT_JEFE_SUBJECT"];
			string sBody = ConfigurationManager.AppSettings["MAIL_ALERT_JEFE_BODY"];

			MailMessage message = new MailMessage();

			MailAddress destination = new MailAddress("cdgonzalez82@gmail.com", jefe.Nombre + " " + jefe.Nombre);
			message.To.Add(destination);


            String subject = sSubject.Replace("{{nombres}}", emp.Nombre).Replace("{{apellidos}}", emp.Nombre);
            String body = sBody.Replace("{{nombres}}", emp.Nombre).Replace("{{apellidos}}", emp.Nombre);


			MailAddress sender = new MailAddress(sSenderEmail, sSenderName);
			message.Subject = subject;
			message.IsBodyHtml = false;

			message.From = sender;


			message.Body = body;

			SmtpClient client = new SmtpClient(smtpServer);
			client.Port = int.Parse(smtpPort);
			client.EnableSsl = useSsl;
			client.Timeout = 100000;
			if (smtpUser != string.Empty)
			{
				System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
				credentials.UserName = smtpUser;
				credentials.Password = smtpPassword;
				client.Credentials = credentials;

			}

			client.Send(message);
		}
	}
}