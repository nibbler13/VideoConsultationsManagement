using System.Net.Mail;
using System;

namespace VideoConsultationsManagement {
	partial class SmsSystem {
		public static string SendInvitation(string number, string url, DateTime dateTime) {
			string subject = "Приглашение на видеоконсультацию";
			string body = HEADER + number + " В открывшемся окне видеоконсультации введите имя и нажмите 'Войти как гость'. " +
				" Для подключения к видеоконсультации";
			if (!dateTime.Equals(new DateTime()))
				body += " в " + dateTime.ToShortTimeString() + " " + dateTime.ToShortDateString();
			body += " пройдите по ссылке: " + url;
			return SendMailToSmsGate(subject, body);
		}

		public static String SendLinks(string number, bool ios, bool android) {
			string result = "";

			if (!ios && !android)
				return result;

			string subject = "Ссылка для установки приложения TrueConf";
			string body = HEADER + number + " Необходимо установить мобильное приложение - ";
			string iosLink = "скачать для Apple iOS (App Store): " + Properties.Settings.Default.linkIos;
			string androidLink = "скачать для Goolge Android (Google Play): " + Properties.Settings.Default.linkAndroid;
			
			if (ios && android) {
				result += SendMailToSmsGate(subject, body + iosLink);
				result += SendMailToSmsGate(subject, body + androidLink);
			} else if (ios && !android) {
				result += SendMailToSmsGate(subject, body + iosLink);
			} else {
				result += SendMailToSmsGate(subject, body + androidLink);
			}

			return result;
		}

		private static string SendMailToSmsGate (string subject, string body) {
			try {
				MailAddress from = new MailAddress(USER + "@" + DOMAIN, "TrueConfApiTest");
				MailAddress to = new MailAddress(TO_ADDRESS);
				
				using (MailMessage message = new MailMessage(from, to)) {
					message.Subject = subject;
					message.Body = body;
					message.CC.Add(COPY);

					SmtpClient client = new SmtpClient(SERVER, 25);
					client.UseDefaultCredentials = false;
					client.Credentials = new System.Net.NetworkCredential(USER, PASSWORD, DOMAIN);
					client.Send(message);
					return "";
				}
			} catch (Exception e) {
				return e.Message + " " + e.StackTrace;
			}
		}
		
		public static string SendReminder(string number, string url, DateTime dateTime) {
			string subject = "Приглашение на видеоконсультацию";
			string body = HEADER + number + " Напоминаем Вам, что в " + dateTime.ToShortTimeString() +
				" начнется видеоконсультация. Для подключения пройдите по ссылке: " + url;
			return SendMailToSmsGate(subject, body);
		}
	}
}
