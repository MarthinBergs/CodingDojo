using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculatorDojo1
{
    class StringCalculator
    {
        public int Add(String inputs)
        {
            if (inputs == String.Empty)
            {
                return 0;
            }
            else
            {
                inputs = foo(inputs);
                string[] numbers = inputs.Split(',', '\n', ';');

                int sum = 0;
                foreach (var item in numbers)
                {
                    sum += int.Parse(item);
                }
                return sum;
            }
        }

        public String foo(String inputs)
        {
            if (inputs.StartsWith("//"))
            {
                inputs = inputs.Substring(4);
            }
            return inputs;
        }
    }
}
