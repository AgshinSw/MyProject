using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class SendRequest
    {
        public void Sendrequest(ICreditManager creditManager, List<ILoggerService> loggers)
        {

            creditManager.Calculate();

            foreach (var log in loggers)
            {
                log.Log();

            }

        }

        public void CreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();

            }

        }

    }
}
