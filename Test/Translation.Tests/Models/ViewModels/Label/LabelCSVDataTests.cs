﻿using NUnit.Framework;
using Shouldly;
using Translation.Client.Web.Models.Label;
using static Translation.Tests.TestHelpers.FakeModelTestHelper;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.Models.ViewModels.Label
{
    [TestFixture]
    public class LabelCSVDataTests
    {
        public LabelCSVData SystemUnderTest { get; set; }

        [SetUp]
        public void run_before_every_test()
        {
            SystemUnderTest = GetLabelCSVData();
        }

        [Test]
        public void LanguageRevisionReadListModel_Parameter()
        {
            SystemUnderTest.LabelKey.ShouldBe(StringOne);
            SystemUnderTest.Language2CharCode.ShouldBe(StringOne);
            SystemUnderTest.Translation.ShouldBe(StringTwo);
        }
    }
}