using System;

namespace UserRepositoryApi.Core.Models
{
    public class Duck : Bird
    {
        public override string Sound() {
            return "Quack!";
        }
    }
}
