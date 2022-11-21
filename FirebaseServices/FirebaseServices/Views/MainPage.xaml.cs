using Plugin.FirebasePushNotification;

namespace FirebaseServices.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            CrossFirebasePushNotification.Current.OnNotificationReceived += Current_OnNotificationReceived;
        }

        private void Current_OnNotificationReceived(object source, FirebasePushNotificationDataEventArgs e)
        {
            
        }
    }
}
