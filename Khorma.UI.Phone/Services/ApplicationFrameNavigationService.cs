// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationFrameNavigationService.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.Services
{
    using System;

    using Microsoft.Phone.Controls;

    /// <summary>
    /// The application frame navigation service.
    /// </summary>
    public class ApplicationFrameNavigationService : INavigationService
    {
        #region Constants and Fields

        /// <summary>
        /// The frame.
        /// </summary>
        private readonly PhoneApplicationFrame frame;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationFrameNavigationService"/> class.
        /// </summary>
        /// <param name="frame">
        /// The frame.
        /// </param>
        public ApplicationFrameNavigationService(PhoneApplicationFrame frame)
        {
            this.frame = frame;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether CanGoBack.
        /// </summary>
        public bool CanGoBack
        {
            get
            {
                return this.frame.CanGoBack;
            }
        }

        /// <summary>
        /// Gets CurrentSource.
        /// </summary>
        public Uri CurrentSource
        {
            get
            {
                return this.frame.CurrentSource;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The go back.
        /// </summary>
        public void GoBack()
        {
            this.frame.GoBack();
        }

        /// <summary>
        /// Navigate.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The navigate.
        /// </returns>
        public bool Navigate(Uri source)
        {
            return this.frame.Navigate(source);
        }

        #endregion
    }
}