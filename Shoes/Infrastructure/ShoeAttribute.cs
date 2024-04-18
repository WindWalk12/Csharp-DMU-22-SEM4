using System.ComponentModel.DataAnnotations;
using Shoes.Models;

namespace Shoes.Infrastructure
{
    public class ShoeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Shoe shoe = value as Shoe;
            if (shoe.Material.ToLower() == "silk" && shoe.Size > 40)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
