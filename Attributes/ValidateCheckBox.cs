using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SignUpPageCore.Attributes
{
    public class ValidateCheckBox : ValidationAttribute,IClientModelValidator
    {

        public override bool IsValid(object value)
        {
              return (bool)value;
        }


        public void AddValidation(ClientModelValidationContext context)
        {

            context.Attributes.Add("data-val-validationcheck", ErrorMessage);
        }

    }
}
