using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Khorma.UI.Phone.Services;

namespace Khorma.UI.Phone.Test.Mocks
{
    public class NavigationServiceMock : INavigationService
    {
        public bool CanGoBack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Uri CurrentSource
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public bool Navigate(Uri source)
        {
            throw new NotImplementedException();
        }
    }
}
