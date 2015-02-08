using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Pikworker_Windows
{
    public partial class SearchResultPage : PhoneApplicationPage
    {
        public SearchResultPage()
        {
            InitializeComponent();
        }

        private void Rectangle_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            }

        private void StackPanel_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile.xaml", UriKind.Relative));
       
        }
    }
}