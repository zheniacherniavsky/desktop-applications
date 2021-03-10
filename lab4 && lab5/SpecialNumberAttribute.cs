using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab2
{
    public class SpecialNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string specialNumber = value.ToString();
                if (specialNumber.StartsWith("-"))
                    return true;
                else
                    this.ErrorMessage = "Инвентарный номер должнен начинаться с символа '-'";
            }
            return false;
        }
    }
}