using System;

namespace UserRepositoryApi.Core.Models
{
    public class Chicken : Bird
    {
        public override string Sound() {
            return "Cluck!";
        }
    }
}
