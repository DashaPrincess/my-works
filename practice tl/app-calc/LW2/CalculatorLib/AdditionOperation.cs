﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public class AdditionOpreation : IOperation
    {
        public string OperatorCode
        {
            get { return "+"; }
        }
        public int Apply(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
    }
}
