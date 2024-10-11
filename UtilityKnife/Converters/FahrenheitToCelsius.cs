using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityKnife.Converters
{
    public class FahrenheitToCelsius
    {
           public double FahrenheitToCelsiusConverter(double FahrenheitTemp)
            {
                double _celsius = 0.0;
                var step1 = Calculator.Calculator.Subtract(FahrenheitTemp, 32);
                var step2 = Calculator.Calculator.Multiply(step1, 5.0);
                _celsius = Calculator.Calculator.Division(step2, 9.0);
                return _celsius;
            }
        }
    }


