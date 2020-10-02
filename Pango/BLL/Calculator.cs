using OCP_AspCore.Models;

namespace OCP_AspCore.BLL
{
    /// <summary>
    /// base class for SOLID principles 
    /// </summary>
    public abstract class Calculator
    {
        protected CalcModel CalcModel { get; private set; }
        protected readonly CalcModel _calcModel;
        public Calculator(CalcModel model)
        {
            _calcModel = model;
            CalcModel = model;
        }
        /// <summary>
        ///  class to overide for different calculation 
        /// </summary>
        /// <returns></returns>
        public abstract double Calculate();

    }
}
