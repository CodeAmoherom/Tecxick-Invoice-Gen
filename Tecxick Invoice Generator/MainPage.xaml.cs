using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tecxick_Invoice_Generator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigateToStartScreen(this);
        }

        /// <summary>
        /// Navigate the Main Screen to Start Screen
        /// </summary>
        /// <param name="RequestedFrom">From Which page this is requesting from</param>
        public async void NavigateToStartScreen(object RequestedFrom)
        {
            await Model.General.Log("Navigation requested <" + (RequestedFrom as Page).ToString() + "><" + typeof(StartScreen).ToString() + ">" );
            PageLoader.Navigate(typeof(StartScreen));
        }

        private async void PageLoader_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            await Model.General.Log("Navigation Failed" + e.Exception.ToString());
        }

        private async void PageLoader_Navigated(object sender, NavigationEventArgs e)
        {
            await Model.General.Log("Navigation success > " + e.SourcePageType.ToString());
        }
    }
}
