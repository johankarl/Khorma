// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModel.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.ViewModels
{
    using System;
    using Khorma.UI.Phone.Services;
    using Microsoft.Phone.Shell;
    using Microsoft.Practices.Prism.ViewModel;

    /// <summary>
    /// The view model.
    /// </summary>
    public abstract class ViewModel : NotificationObject, IDisposable
    {
        #region Constants and Fields

        /// <summary>
        /// The navigation service.
        /// </summary>
        private readonly INavigationService navigationService;

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">
        /// The navigation Service.
        /// </param>
        protected ViewModel(INavigationService navigationService)
        {
            PhoneApplicationService.Current.Deactivated += this.OnDeactivated;
            PhoneApplicationService.Current.Activated += this.OnActivated;
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="ViewModel"/> class. 
        /// </summary>
        ~ViewModel()
        {
            this.Dispose();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets NavigationService.
        /// </summary>
        public INavigationService NavigationService
        {
            get
            {
                return this.navigationService;
            }
        }

        /// <summary>
        /// Gets or sets OnActivated.
        /// </summary>
        public EventHandler<ActivatedEventArgs> OnActivated { get; set; }

        /// <summary>
        /// Gets or sets OnDeactivated.
        /// </summary>
        public EventHandler<DeactivatedEventArgs> OnDeactivated { get; set; }

        #endregion

        #region Public Methods     

        /// <summary>
        /// The is being activated.
        /// </summary>
        public abstract void IsBeingActivated();

        /// <summary>
        /// The is being deactivated.
        /// </summary>
        public virtual void IsBeingDeactivated()
        {
        }
        
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
                PhoneApplicationService.Current.Deactivated -= this.OnDeactivated;
                PhoneApplicationService.Current.Activated -= this.OnActivated;
            }

            this.disposed = true;
        }

        #endregion
    }
}