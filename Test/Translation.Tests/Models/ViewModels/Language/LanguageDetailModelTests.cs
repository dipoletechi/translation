﻿using NUnit.Framework;
using Shouldly;
using Translation.Client.Web.Models.Language;
using static Translation.Tests.TestHelpers.FakeModelTestHelper;
using static Translation.Tests.TestHelpers.FakeEntityTestHelper;


namespace Translation.Tests.Models.ViewModels.Language
{
    [TestFixture]
    public class LanguageDetailModelTests
    {
        public LanguageDetailModel SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetLanguageDetailModel();
        }

        [Test]
        public void LanguageDetailModel_Title()
        {
            Assert.AreEqual(SystemUnderTest.Title, "language_detail_title");
        }
        [Test]
        public void LanguageDetailModel_Parameter()
        {
            SystemUnderTest.Icon.ShouldBe(null);
        }

    }
}
