using System.ComponentModel.DataAnnotations;

namespace Shoes.Infrastructure
{
    public class ProductionDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dt = DateTime.Parse(value.ToString());
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
