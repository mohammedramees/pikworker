using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections; // for 'IEnumerable'

namespace Pikworker_Windows
{
    public partial class SearchPage : PhoneApplicationPage
    {
        public SearchPage()
        {
            InitializeComponent();
        
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SearchResultPage.xaml", UriKind.Relative));
        }

       
    }
}