using MathiasDesign.Core.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathiasDesign.Core.Features.Snackbar
{
    public class SnackBarViewModel
    {
        private INotificationManager notificationManager;

        public SnackBarViewModel(INotificationManager notificationManager)
        {
            this.notificationManager = notificationManager;
        }

        public void ShowMessageFromManager()
        {
            notificationManager.MakeNotification("Hello world");
        }

        public async Task<bool> ShowMessageFromManagerAsync()
        {
            var result = await notificationManager.MakeNotificationAsync("Hello world");
            if (result)
            {
                notificationManager.MakeNotification("You clicked");
            }
            else
            {
                notificationManager.MakeNotification("You did not click");
            }

            return result;
        }
    }
}
