﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculatorBlank
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "") return 0;
            return numbers.Split(',', 'n')
                .Select(int.Parse)
                .Sum();
        }
    }
}