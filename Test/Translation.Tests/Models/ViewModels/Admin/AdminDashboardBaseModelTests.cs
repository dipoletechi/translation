﻿using NUnit.Framework;

using Translation.Client.Web.Models.Admin;
using static Translation.Tests.TestHelpers.FakeModelTestHelper;

namespace Translation.Tests.Client.Models.ViewModels.Admin
{
    [TestFixture]
    public sealed class AdminDashboardBaseModelTests
    {
        public AdminDashboardBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetAdminDashboardBaseModel();
        }

        [Test]
        public void AdminDashboardBaseModel_Title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "admin_dashboard_title");
        }
    }
}