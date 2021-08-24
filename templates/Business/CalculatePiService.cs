using System;

namespace PROJECTNAME.Business
{
    public class CalculatePiService : ICalculatePiService
    {
        public double Add(int number) {
            return Math.PI + number;
        }

        public double Minus(int number) {
            return Math.PI - number;
        }
    }
}
