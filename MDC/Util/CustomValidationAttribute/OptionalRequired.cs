using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDC.Util.CustomValidationAttribute
{
    //[OptionalRequired(new string[] { nameof(MobileNumber), nameof(LandLineNumber), nameof(FaxNumber) }, MinimumAmount = 2)]
    public class OptionalRequired: ValidationAttribute, IClientValidatable
    {
        
        /// <summary>
        /// The name of the client validation rule
        /// </summary>
        private readonly string type = "optionalrequired";

        /// <summary>
        /// The (minimum) amount of properties that are required to be filled in. Use -1 when there is no minimum. Default 1.
        /// </summary>
        public int MinimumAmount { get; set; } = 1;
        /// <summary>
        /// The maximum amount of properties that need to be filled in. Use -1 when there is no maximum. Default -1.
        /// </summary>
        public int MaximumAmount { get; set; } = -1;

        /// <summary>
        /// The collection of property names
        /// </summary>
        public string[] Properties { get; set; }


        public OptionalRequired(string[] properties)
        {
            Properties = properties;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int validPropertyValues = 0;

            // Iterate the properties in the collection
            foreach (var propertyName in Properties)
            {
                // Find the property
                var property = validationContext.ObjectType.GetProperty(propertyName);

                // When the property is not found throw an exception
                if (property == null)
                    throw new ArgumentException($"Proprietà {propertyName} non trovata.");

                // Get the value of the property
                var propertyValue = property.GetValue(validationContext.ObjectInstance);

                // When the value is not null and not empty (very simple validation)
                if (propertyValue != null && !String.IsNullOrEmpty(propertyValue.ToString()))
                    validPropertyValues++;
            }

            // Check if the minimum allowed is exceeded
            if (MinimumAmount != -1 && validPropertyValues < MinimumAmount)
            {
                if (MinimumAmount == 1)
                    return new ValidationResult($"E' richiesto l'inserimento di almeno un campo.");
                else
                    return new ValidationResult($"E' richiesto l'inserimento di un minimo di {MinimumAmount} campi.");
            }

            // Check if the maximum allowed is exceeded
            else if (MaximumAmount != -1 && validPropertyValues > MaximumAmount)
            {
                if (MaximumAmount == 1)
                    return new ValidationResult($"Puoi inserire solamente {MaximumAmount} campo");
                else
                    return new ValidationResult($"Puoi inserire solamente {MaximumAmount} campi");
            }
            // 
            else
                return ValidationResult.Success;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule();

            rule.ErrorMessage = "Enter your error message here or manipulate it on the client side";
            rule.ValidationParameters.Add("minimum", MinimumAmount);
            rule.ValidationParameters.Add("maximum", MaximumAmount);
            rule.ValidationParameters.Add("properties", string.Join(",", Properties));

            rule.ValidationType = type;

            yield return rule;
        }
    }
}