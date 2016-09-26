using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathiasDesign.Core.Managers
{
    public interface INotificationManager
    {
        void MakeNotification(string text);

        Task<bool> MakeNotificationAsync(string text);
    }
}
