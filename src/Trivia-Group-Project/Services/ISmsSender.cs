using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_Group_Project.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
