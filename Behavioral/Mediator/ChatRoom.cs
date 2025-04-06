using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{DateTime.Now} [{user.name}]: {message}");
        }
    }
}
