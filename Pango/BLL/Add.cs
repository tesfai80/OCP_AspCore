﻿using OCP_AspCore.Models;

namespace OCP_AspCore.BLL
{
    public class Add : Calculator
    {
        public Add(CalcModel calcModel)
            : base(calcModel)
        {

        }
        public override double Calculate()
        {
            return _calcModel.FirstNumber + _calcModel.SecondNumber;
        }
    }
}
