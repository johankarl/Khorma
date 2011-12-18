// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPhoneMemoryViewModel.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.ViewModels
{
    using System;
    using System.ComponentModel;

    using Khorma.UI.Phone.Services;

    using Microsoft.Phone.Shell;

    /// <summary>
    /// The i phone memory view model.
    /// </summary>
    public interface IPhoneMemoryViewModel
    {
        #region Public Events

        /// <summary>
        /// The property changed.
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets ApplicationCurrentMemoryUsage.
        /// </summary>
        string ApplicationCurrentMemoryUsage { get; }

        /// <summary>
        /// Gets DeviceTotalMemory.
        /// </summary>
        string DeviceTotalMemory { get; }

        /// <summary>
        /// Gets NavigationService.
        /// </summary>
        INavigationService NavigationService { get; }

        /// <summary>
        /// Gets or sets OnActivated.
        /// </summary>
        EventHandler<ActivatedEventArgs> OnActivated { get; set; }

        /// <summary>
        /// Gets or sets OnDeactivated.
        /// </summary>
        EventHandler<DeactivatedEventArgs> OnDeactivated { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The dispose.
        /// </summary>
        void Dispose();

        /// <summary>
        /// The is being activated.
        /// </summary>
        void IsBeingActivated();

        /// <summary>
        /// The is being deactivated.
        /// </summary>
        void IsBeingDeactivated();

        #endregion
    }
}