// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PhoneMemoryViewModelFixture.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.Test.Fixtures
{
    using Khorma.UI.Phone.Test.Mocks;

    using Khorma.UI.Phone.ViewModels;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The phone memory view model fixture.
    /// </summary>
    [TestClass]
    public class PhoneMemoryViewModelFixture
    {
        #region Public Methods

        /// <summary>
        /// The memory usage info shows after initiate.
        /// </summary>
        [TestMethod]
        public void MemoryUsageInfoShowsAfterInitiate()
        {
            var viewModel = new PhoneMemoryViewModel(new NavigationServiceMock());

            string deviceTotalMemory = viewModel.DeviceTotalMemory;
            string applicationCurrentMemoryUsage = viewModel.ApplicationCurrentMemoryUsage;

            Assert.IsTrue(deviceTotalMemory.Contains("KB"));
            Assert.IsTrue(applicationCurrentMemoryUsage.Contains("KB"));

            Assert.IsTrue(deviceTotalMemory.Length > 2);
            Assert.IsTrue(applicationCurrentMemoryUsage.Length > 2);
        }

        #endregion
    }
}