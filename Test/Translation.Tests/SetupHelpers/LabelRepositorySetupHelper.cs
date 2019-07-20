﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Moq;

using Translation.Data.Entities.Domain;
using Translation.Data.Repositories.Contracts;
using static Translation.Tests.TestHelpers.FakeEntityTestHelper;
using static Translation.Tests.TestHelpers.FakeConstantTestHelper;

namespace Translation.Tests.SetupHelpers
{
    public static class LabelRepositorySetupHelper
    {
        public static void Setup_SelectAfter_Returns_Labels(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.SelectAfter(It.IsAny<Expression<Func<Label, bool>>>(),
                                                It.IsAny<Guid>(),
                                                It.IsAny<int>(),
                                                It.IsAny<Expression<Func<Label, object>>>(),
                                                It.IsAny<bool>(), false))
                      .ReturnsAsync(new List<Label> { GetLabel() });
        }

        public static void Setup_SelectMany_Returns_Labels(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.SelectMany(It.IsAny<Expression<Func<Label, bool>>>(),
                                               It.IsAny<int>(),
                                               It.IsAny<int>(),
                                               It.IsAny<Expression<Func<Label, object>>>(),
                                               It.IsAny<bool>(), false))
                      .ReturnsAsync(new List<Label> { GetLabel() });
        }

        public static void Setup_Count_Returns_Ten(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Count(It.IsAny<Expression<Func<Label, bool>>>(),
                                          It.IsAny<bool>()))
                      .ReturnsAsync(Ten);
        }

        public static void Verify_SelectAfter(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.SelectAfter(It.IsAny<Expression<Func<Label, bool>>>(),
                                                 It.IsAny<Guid>(),
                                                 It.IsAny<int>(),
                                                 It.IsAny<Expression<Func<Label, object>>>(),
                                                 It.IsAny<bool>(), false));
        }

        public static void Verify_SelectMany(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.SelectAfter(It.IsAny<Expression<Func<Label, bool>>>(),
                                                 It.IsAny<Guid>(),
                                                 It.IsAny<int>(),
                                                 It.IsAny<Expression<Func<Label, object>>>(),
                                                 It.IsAny<bool>(), false));
        }

        public static void Verify_Count(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Count(It.IsAny<Expression<Func<Label, bool>>>(),
                                          It.IsAny<bool>()))
                      .ReturnsAsync(Ten);
        }

        public static void Setup_SelectById_Returns_OrganizationOneProjectOneLabelOne(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.SelectById(It.IsAny<long>()))
                      .ReturnsAsync(GetOrganizationOneProjectOneLabelOne());
        }

        public static void Setup_SelectById_Returns_OrganizationOneProjectOneLabelOneNotExist(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.SelectById(It.IsAny<long>()))
                      .ReturnsAsync(GetOrganizationOneProjectOneLabelOneNotExist());
        }

        public static void Verify_SelectById(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.SelectById(It.IsAny<long>()));
        }

        public static void Setup_Select_Returns_OrganizationOneProjectOneLabelOne(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Select(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(GetOrganizationOneProjectOneLabelOne());
        }

        public static void Setup_Select_Returns_OrganizationOneProjectOneLabelOneNotActive(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Select(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(GetOrganizationOneProjectOneLabelOneNotActive());
        }

        public static void Setup_Select_Returns_OrganizationTwoProjectOneLabelOne(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Select(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(GetOrganizationTwoProjectOneLabelOne());
        }

        public static void Setup_Select_Returns_OrganizationOneProjectOneLabelOneNotExist(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Select(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(GetOrganizationOneProjectOneLabelOneNotExist());
        }

        public static void Verify_Select(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.Select(It.IsAny<Expression<Func<Label, bool>>>(), false));
        }

        public static void Setup_Update_Success(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Update(It.IsAny<long>(),
                                           It.IsAny<Label>()))
                      .ReturnsAsync(true);
        }

        public static void Setup_Update_Failed(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Update(It.IsAny<long>(),
                                           It.IsAny<Label>()))
                      .ReturnsAsync(false);
        }

        public static void Verify_Update(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.Update(It.IsAny<long>(),
                                            It.IsAny<Label>()));
        }

        public static void Setup_Delete_Success(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Delete(It.IsAny<long>(),
                                           It.IsAny<long>()))
                      .ReturnsAsync(true);
        }

        public static void Setup_Delete_Failed(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Delete(It.IsAny<long>(),
                                           It.IsAny<long>()))
                      .ReturnsAsync(false);
        }

        public static void Verify_Delete(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.Delete(It.IsAny<long>(),
                                            It.IsAny<long>()));
        }

        public static void Setup_Any_Returns_False(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Any(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(false);
        }

        public static void Setup_Any_Returns_True(this Mock<ILabelRepository> repository)
        {
            repository.Setup(x => x.Any(It.IsAny<Expression<Func<Label, bool>>>(), false))
                      .ReturnsAsync(true);
        }

        public static void Verify_Any(this Mock<ILabelRepository> repository)
        {
            repository.Verify(x => x.Any(It.IsAny<Expression<Func<Label, bool>>>(), false));
        }
    }
}