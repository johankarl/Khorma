// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelLocator.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.ViewModels
{
    using System;
    using Khorma.UI.Phone.Services;

    /// <summary>
    /// The view model locator.
    /// </summary>
    public class ViewModelLocator : IDisposable
    {
        #region Constants and Fields

        /// <summary>
        /// The container locator.
        /// </summary>
        private readonly ContainerLocator containerLocator;

        /// <summary>
        /// The disposed.
        /// </summary>
        private bool disposed;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocator"/> class.
        /// </summary>
        public ViewModelLocator()
        {
            this.containerLocator = new ContainerLocator();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets PhoneMemoryViewModel.
        /// </summary>
        public IPhoneMemoryViewModel PhoneMemoryViewModel
        {
            get
            {
                return this.containerLocator.Container.Resolve<IPhoneMemoryViewModel>();
            }
        }

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
                this.containerLocator.Dispose();
            }

            this.disposed = true;
        }

        #endregion
    }
}