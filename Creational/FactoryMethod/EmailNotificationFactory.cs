using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class EmailNotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
