using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SA51ADWebApp1.NotificationService
{
    public static class PushNotification
    {
        public static async Task Send(string title, string body)
        {

            var defaultApp = FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "key.json")),
            });
            
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = title,
                    Body = body
                },               
                Topic = "notification"
            };
            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);
            defaultApp.Delete();
        }
    }
}
