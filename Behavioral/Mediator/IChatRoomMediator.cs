using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }
}
