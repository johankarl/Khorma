// --------------------------------------------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone
{
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Navigation;

    using Khorma.UI.Phone.ViewModels;

    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;

    /// <summary>
    /// The app.
    /// </summary>
    public partial class App : Application
    {
        #region Constants and Fields

        /// <summary>
        /// The phone application initialized.
        /// </summary>
        private bool phoneApplicationInitialized;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class. 
        /// Constructor for the Application object.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            this.UnhandledException += this.Application_UnhandledException;

            // Standard Silverlight initialization
            this.InitializeComponent();

            // Phone-specific initialization
            this.InitializePhoneApplication();

            // Show graphics profiling information while debugging.
            if (Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                // Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are handed off to GPU with a colored overlay.
                // Application.Current.Host.Settings.EnableCacheVisualization = true;

                // Disable the application idle detection by setting the UserIdleDetectionMode property of the
                // application's PhoneApplicationService object to Disabled.
                // Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                // and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Provides easy access to the root frame of the Phone Application.
        /// </summary>
        /// <returns>The root frame of the Phone Application.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets ViewModelLocator.
        /// </summary>
// ReSharper disable UnusedMember.Local
        private ViewModelLocator ViewModelLocator
// ReSharper restore UnusedMember.Local
        {
            get
            {
                return (ViewModelLocator)this.Resources["ViewModelLocator"];
            }
        }

        #endregion

        // Code to execute when the application is launching (eg, from Start)
        // This code will not execute when the application is reactivated

        // Code to execute when the application is activated (brought to foreground)
        // This code will not execute when the application is first launched
        #region Methods

        /// <summary>
        /// The application_ activated.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
        }

        // Code to execute when the application is deactivated (sent to background)
        // This code will not execute when the application is closing

        // Code to execute when the application is closing (eg, user hit Back)
        // This code will not execute when the application is deactivated
        /// <summary>
        /// The application_ closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
            this.ViewModelLocator.Dispose();
        }

        /// <summary>
        /// The application_ deactivated.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        /// <summary>
        /// The application_ launching.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
        }

        // Code to execute if a navigation fails

        // Code to execute on Unhandled Exceptions
        /// <summary>
        /// The application_ unhandled exception.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                Debugger.Break();
            }
        }

        /// <summary>
        /// The complete initialize phone application.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
// ReSharper disable RedundantCheckBeforeAssignment
            if (this.RootVisual != this.RootFrame)
// ReSharper restore RedundantCheckBeforeAssignment
            {
                this.RootVisual = this.RootFrame;
            }

            // Remove this handler since it is no longer needed
            this.RootFrame.Navigated -= this.CompleteInitializePhoneApplication;
        }

        /// <summary>
        /// The initialize phone application.
        /// </summary>
        private void InitializePhoneApplication()
        {
            if (this.phoneApplicationInitialized)
            {
                return;
            }

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            this.RootFrame = new PhoneApplicationFrame();
            this.RootFrame.Navigated += this.CompleteInitializePhoneApplication;

            // Handle navigation failures
            this.RootFrame.NavigationFailed += this.RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            this.phoneApplicationInitialized = true;
        }

        /// <summary>
        /// The root frame_ navigation failed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                Debugger.Break();
            }
        }

        #endregion
    }
}