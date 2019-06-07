﻿using NodaTime;

namespace Translation.Client.Web.Models.InputModels
{
    public class DateInputModel : InputModel
    {
        public new Instant Value { get; set; }

        public DateInputModel(string name, string labelKey, bool isRequired = false) : base(name, labelKey, isRequired)
        {

        }
    }
}