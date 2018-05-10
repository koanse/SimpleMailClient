using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Авторизация на SMTP сервере
            SmtpClient Smtp = new SmtpClient("smtp.bk.ru", 25);
            Smtp.Credentials = new NetworkCredential("_antony_", "anaKonda88");
            //Smtp.EnableSsl = false;

            //Формирование письма
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("_antony_@bk.ru");
            Message.To.Add(new MailAddress("coant@yandex.ru"));
            Message.Subject = "Заголовок";
            Message.Body = "Сообщение";

            /*
            //Прикрепляем файл
            string file = "C:\\file.zip";
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);

            // Добавляем информацию для файла
            ContentDisposition disposition = attach.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

            Message.Attachments.Add(attach);*/

            Smtp.Send(Message);//отправка
        }
    }
}
