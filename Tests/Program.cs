using System.ComponentModel.DataAnnotations;
using LibraryDTO;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business()
            {
                BusinessID = "879788",
                HomeNumber = "23",
            };
            ValidateModel(business);

        }
        public static void ValidateModel(object model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model, null, null);
            bool IsValid = Validator.TryValidateObject(model, context, results, validateAllProperties: true);
            if (IsValid == false)
            {
                foreach (var vr in results)
                {
                    Console.WriteLine(vr.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("The model is correct");
            }
        }
    }
}
