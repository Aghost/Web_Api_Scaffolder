using System;
using UserRepositoryApi.Business.Interfaces;

namespace UserRepositoryApi.Business.Services
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
