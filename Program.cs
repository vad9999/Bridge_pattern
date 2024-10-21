﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService EmailService = new ConcreteNotificationService(new EmailNotification());
            EmailService.NotifyText("abc");
            EmailService.NotifyHtml("abc");

            NotificationService smsService = new ConcreteNotificationService(new SmsNotification());
            smsService.NotifyText("abc");
            smsService.NotifyHtml("abc");
            Console.ReadLine();
        }
    }
}
