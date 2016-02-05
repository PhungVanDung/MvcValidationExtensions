﻿using System;
using WebTest.Models;

namespace WebTest.UnitTest.Factory
{
    public static class ModelFactory
    {
        public static TestModel ValidTestModel => new TestModel()
        {
            RequiredIntControl = "require Some int",
            SomeIntThatMightBeRequired = 100,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel InvalidGreaterThanIntModel => new TestModel()
        {
            RequiredIntControl = "require Some int",
            SomeIntThatMightBeRequired = 100,
            SomeValue = 55,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel InvalidLessThanDateModel => new TestModel()
        {
            RequiredIntControl = "require Some int",
            SomeIntThatMightBeRequired = 100,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today,
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel InvalidLessThanEqualToDateModel => new TestModel()
        {
            RequiredIntControl = "require Some int",
            SomeIntThatMightBeRequired = 100,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today.AddDays(1.0),
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel InvalidGreaterThanEqualToDateModel => new TestModel()
        {
            RequiredIntControl = "require Some int",
            SomeIntThatMightBeRequired = 100,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today.AddDays(-1.0)
        };

        

        public static TestModel ValidRequiredIfValueModel => new TestModel()
        {
            RequiredIntControl = "15",
            SomeIntThatMightBeRequired = 100,
            SomeRequiredIfValue = 200,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel InvalidRequiredIfValueModel => new TestModel()
        {
            RequiredIntControl = "15",
            SomeIntThatMightBeRequired = null,
            SomeRequiredIfValue = 200,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today
        };

        public static TestModel ValidRequiredIfAnyValuesModel => new TestModel()
        {
            RequiredIntControl = "15",
            SomeIntThatMightBeRequired = 100,
            SomeRequiredIfValue = 200,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today,
            RequiredIfAnyValue = 15,
            RequiredIfAnyValueControl = "ValTwo"
        };

        public static TestModel InvalidRequiredIfAnyValuesModel => new TestModel()
        {
            RequiredIntControl = "15",
            SomeIntThatMightBeRequired = 100,
            SomeRequiredIfValue = 200,
            SomeValue = 60,
            RequiredInt = 61,
            SomeOtherDate = DateTime.Today,
            SomeDate = DateTime.Today.AddDays(-1.0),
            HiddentInt = 55,
            HiddenDateTime = DateTime.Today,
            KendoDateOther = DateTime.Today,
            KendoDate = DateTime.Today,
            RequiredIfAnyValueControl = "ValThree"
        };

        public static class RequiredIfModels
        {
            public static TestModel ValidRequiredIfModel => new TestModel()
            {
                RequiredIntControl = null,
                SomeIntThatMightBeRequired = null,
                SomeValue = 60,
                RequiredInt = 61,
                SomeOtherDate = DateTime.Today,
                SomeDate = DateTime.Today.AddDays(-1.0),
                HiddentInt = 55,
                HiddenDateTime = DateTime.Today,
                KendoDateOther = DateTime.Today,
                KendoDate = DateTime.Today
            };

            public static TestModel InvalidRequiredIfModel => new TestModel()
            {
                RequiredIntControl = "require Some int",
                SomeIntThatMightBeRequired = null,
                SomeValue = 60,
                RequiredInt = 61,
                SomeOtherDate = DateTime.Today,
                SomeDate = DateTime.Today.AddDays(-1.0),
                HiddentInt = 55,
                HiddenDateTime = DateTime.Today,
                KendoDateOther = DateTime.Today,
                KendoDate = DateTime.Today
            };

            public static TestModel RequiredIfEmptyStringModel => new TestModel()
            {
                RequiredIntControl = "",
                SomeIntThatMightBeRequired = 100,
                SomeValue = 60,
                RequiredInt = 61,
                SomeOtherDate = DateTime.Today,
                SomeDate = DateTime.Today.AddDays(-1.0),
                HiddentInt = 55,
                HiddenDateTime = DateTime.Today,
                KendoDateOther = DateTime.Today,
                KendoDate = DateTime.Today
            };

            public static TestModel RequiredIfWhitespaceModel => new TestModel()
            {
                RequiredIntControl = "   ",
                SomeIntThatMightBeRequired = 100,
                SomeValue = 60,
                RequiredInt = 61,
                SomeOtherDate = DateTime.Today,
                SomeDate = DateTime.Today.AddDays(-1.0),
                HiddentInt = 55,
                HiddenDateTime = DateTime.Today,
                KendoDateOther = DateTime.Today,
                KendoDate = DateTime.Today
            };

            public static TestModel RequiredIfNullModel => new TestModel()
            {
                RequiredIntControl = null,
                SomeIntThatMightBeRequired = 100,
                SomeValue = 60,
                RequiredInt = 61,
                SomeOtherDate = DateTime.Today,
                SomeDate = DateTime.Today.AddDays(-1.0),
                HiddentInt = 55,
                HiddenDateTime = DateTime.Today,
                KendoDateOther = DateTime.Today,
                KendoDate = DateTime.Today
            };
        }
    }
}
