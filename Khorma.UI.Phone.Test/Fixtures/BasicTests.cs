// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BasicTests.cs" company="Maazart">
//   Copyright (c) Maazart. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Khorma.UI.Phone.Test.Fixtures
{
    using Microsoft.Silverlight.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The basic tests.
    /// </summary>
    [TestClass]
    public class BasicTests : SilverlightTest
    {
        #region Public Methods

        /// <summary>
        /// The always fail.
        /// </summary>
        [TestMethod, Ignore]
        public void AlwaysFail()
        {
            Assert.IsFalse(true, "always fail");
        }

        /// <summary>
        /// The always pass.
        /// </summary>
        [TestMethod]
        public void AlwaysPass()
        {
            Assert.IsTrue(true, "always true");
        }

        #endregion
    }
}