using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class User
    {
        public string name { get; }
        private IChatRoomMediator _chatRoom;

        public User(string name, IChatRoomMediator chatRoom)
        {
            this.name = name;
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom.ShowMessage(this, message);
        }
    }
}
