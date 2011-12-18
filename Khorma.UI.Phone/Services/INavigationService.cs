// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INavigationService.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.Services
{
    using System;

    /// <summary>
    /// The i navigation service.
    /// </summary>
    public interface INavigationService
    {
        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether CanGoBack.
        /// </summary>
        bool CanGoBack { get; }

        /// <summary>
        /// Gets CurrentSource.
        /// </summary>
        Uri CurrentSource { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The go back.
        /// </summary>
        void GoBack();

        /// <summary>
        /// The navigate.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The navigate.
        /// </returns>
        bool Navigate(Uri source);

        #endregion
    }
}