using System.ComponentModel.DataAnnotations;
using Rocket.Extensions;

namespace Rocket.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class DocumentValidation : ValidationAttribute
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return value != null && ((string) value).ValidateDocument();
        }
    }
}
