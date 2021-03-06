﻿using CMLearningWords.WebUI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CMLearningWords.WebUI.HelpAttributes
{
    //public class StringArrayRequiredAttribute : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        string[] array = value as string[];

    //        if (array == null || array.Any(item => string.IsNullOrEmpty(item)))
    //            return new ValidationResult(this.ErrorMessage);
    //        else
    //            return ValidationResult.Success;
    //    }

    //    public override string FormatErrorMessage(string name)
    //    {
    //        return String.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
    //    }
    //}

    public class MinValueAttribute : ValidationAttribute
    {
        private readonly int _number;
        public MinValueAttribute(int number)
        {
            _number = number;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            GenerateTestYourselfViewModel model = (GenerateTestYourselfViewModel)validationContext.ObjectInstance;
            if (model.Number < _number)
                return new ValidationResult(this.ErrorMessage);
            else
                return ValidationResult.Success;
        }
    }
}
