using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class SmsNotificationCreator : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
