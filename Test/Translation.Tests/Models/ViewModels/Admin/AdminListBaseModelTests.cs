﻿using NUnit.Framework;

using Translation.Client.Web.Models.Admin;
using static Translation.Tests.TestHelpers.FakeModelTestHelper;

namespace Translation.Tests.Client.Models.ViewModels.Admin
{
    [TestFixture]
    public sealed class AdminListBaseModelTests
    {
        public AdminListBaseModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetAdminListBaseModel();
        }

        [Test]
        public void AdminAdminListBaseModel_Title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "admin_list_title");
        }
    }
}