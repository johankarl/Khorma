// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhoneMemoryViewModel.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.ViewModels
{
    using System.Diagnostics.CodeAnalysis;
    using Khorma.UI.Phone.Services;
    using Microsoft.Phone.Info;

    /// <summary>
    /// The phone memory view model.
    /// </summary>
    public class PhoneMemoryViewModel : ViewModel, IPhoneMemoryViewModel
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneMemoryViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">
        /// The navigation service.
        /// </param>
        public PhoneMemoryViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.DeviceTotalMemory =
                FormatKBytesString((long)DeviceExtendedProperties.GetValue("DeviceTotalMemory"));
            this.ApplicationCurrentMemoryUsage =
                FormatKBytesString((long)DeviceExtendedProperties.GetValue("ApplicationCurrentMemoryUsage"));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets ApplicationCurrentMemoryUsage.
        /// </summary>
        public string ApplicationCurrentMemoryUsage { get; private set; }

        /// <summary>
        /// Gets DeviceTotalMemory.
        /// </summary>
        public string DeviceTotalMemory { get; private set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The is being activated.
        /// </summary>
        public override void IsBeingActivated()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// The format k bytes string.
        /// </summary>
        /// <param name="bytes">
        /// The value.
        /// </param>
        /// <returns>
        /// The format k bytes string.
        /// </returns>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1625:ElementDocumentationMustNotBeCopiedAndPasted",
            Justification = "Reviewed. Suppression is OK here.")]
        private static string FormatKBytesString(long bytes)
        {
            return string.Format("{0:n} KB", bytes / 1024);
        }

        #endregion
    }
}