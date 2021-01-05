using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using UserNotifications;

namespace XamarinPractice.iOS
{
    internal class UserNotificationCenterDelegate : UNUserNotificationCenterDelegate
    {
        public UserNotificationCenterDelegate()
        {
        }
        //This will be called when the notification is received when the app is in Foreground

        public override void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler)
        {
           // var RequestCode = notification.Request.Content.UserInfo["Code"].ToString();                   
            completionHandler(UNNotificationPresentationOptions.Alert);
           

        }

        //This will be called when a user tap a notification and the app will be back in foreground

        public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
        {
            if (response.IsDefaultAction)
            {
               // var Notify = response.Notification.Request.Content;
               // var Code = Notify.UserInfo["Code"];
               
            }
            // Complete handling the notification.
            completionHandler();
        }
    }
}