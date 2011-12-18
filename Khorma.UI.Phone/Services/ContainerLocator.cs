// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContainerLocator.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.Services
{
    using System;
    using System.Windows;

    using Funq;

    using Khorma.UI.Phone.ViewModels;

    /// <summary>
    /// The container locator.
    /// </summary>
    public class ContainerLocator : IDisposable
    {
        #region Constants and Fields

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerLocator"/> class.
        /// </summary>
        public ContainerLocator()
        {
            this.Container = new Container();
            this.ConfigureContainer();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets Container.
        /// </summary>
        public Container Container { get; private set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.Container.Dispose();
            }

            this.disposed = true;
        }

        /// <summary>
        /// The configure container.
        /// </summary>
        private void ConfigureContainer()
        {
            // Register Stores and Services
            this.Container.Register<INavigationService>(
                c => new ApplicationFrameNavigationService(((App)Application.Current).RootFrame));

            // Register ViewModels
            this.Container.Register<IPhoneMemoryViewModel>(c => new PhoneMemoryViewModel(c.Resolve<INavigationService>())).ReusedWithin(
                ReuseScope.None);
        }

        #endregion
    }
}