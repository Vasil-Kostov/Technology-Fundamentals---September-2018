using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    public class Data
    {
        public static List<Calculator> PreviousCalculations { get; set; } = new List<Calculator>();
    }
}
