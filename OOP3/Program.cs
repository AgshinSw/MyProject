using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager credit1 = new Credit1Manager();
            ICreditManager credit2 = new Credit2Manager();
            ICreditManager credit3 = new Credit3Manager();

            DatabaseLoggerService databaseLogger = new DatabaseLoggerService();
            FileLoggerService fileLogger = new FileLoggerService();
            SmsLoggerService smslogger = new SmsLoggerService();

            List<ILoggerService> loggerservices = new List<ILoggerService>() { databaseLogger, fileLogger, smslogger };

            SendRequest sendrequest = new SendRequest();
            sendrequest.Sendrequest(credit1, loggerservices);
            sendrequest.Sendrequest(credit2, loggerservices);
            sendrequest.Sendrequest(credit3, loggerservices);

            List<ICreditManager> credits = new List<ICreditManager>() {credit1,credit2};
            
            //sendrequest.CreditPreinformation(credits);

        }
    }
}
