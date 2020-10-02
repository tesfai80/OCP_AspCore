using System.ComponentModel.DataAnnotations;

namespace OCP_AspCore.Models
{
    public class CalcModel
    {
        [Required(ErrorMessage = "First Number is required")]
        public double FirstNumber { get; set; }
        [Required(ErrorMessage = "Second Number is required")]
        public double SecondNumber { get; set; }
        public string Operators { get; set; }
        public double Result { get; set; }
        public bool Colored { get; set; }
        public bool EvenOrOdd { get; set; }
    }
}
