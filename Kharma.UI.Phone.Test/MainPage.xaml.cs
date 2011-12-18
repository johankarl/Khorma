// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPage.xaml.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Kharma.UI.Phone.Test
{
    using System.Windows;

    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;
    using Microsoft.Silverlight.Testing;

    /// <summary>
    /// The main page.
    /// </summary>
    public partial class MainPage
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// The main page_ loaded.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            SystemTray.IsVisible = false;

            var testPage = UnitTestSystem.CreateTestPage() as IMobileTestPage;
            if (testPage != null)
            {
                this.BackKeyPress += (x, xe) => xe.Cancel = testPage.NavigateBack();
                ((PhoneApplicationFrame)Application.Current.RootVisual).Content = testPage;
            }
        }

        #endregion
    }
}