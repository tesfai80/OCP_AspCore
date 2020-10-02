using OCP_AspCore.Models;

namespace OCP_AspCore.BLL
{
    public class Exponent : Calculator
    {
        public Exponent(CalcModel model)
            : base(model)
        {

        }
        public override double Calculate()
        {
            return Power(_calcModel.FirstNumber, _calcModel.SecondNumber);
        }
        /// <summary>
        /// recurtion function to return exponent number
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static double Power(double x, double y)
        {
            if (y == 0)
                return 1;
            else
                return x * Power(x, y - 1);
        }
    }
}
