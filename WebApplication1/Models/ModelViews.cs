using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
        public class ModelViews
        {
            [Required(ErrorMessage ="Ошибка")]
            [Range(typeof(double), "0", "999999999999999999999999999999999999999999999")]  
            public double radius_shara { get; set; }

            [Required(ErrorMessage = "Ошибка")]
            [Range(typeof(double), "0", "999999999999999999999999999999999999999999999")]
             public double radius_okrujnosti { get; set; }

            [Required(ErrorMessage = "Ошибка")]
            [Range(typeof(double), "0", "999999999999999999999999999999999999999999999")]  
            public double height { get; set; }

        //internal object? Area(double radius_shara, double radius_okrujnosti, double height)
        //{
        //    throw new NotImplementedException();
        //}
            internal bool IsValidNumber(string value)
            {
                double result;
                return double.TryParse(value, out result);
            }
    }
}