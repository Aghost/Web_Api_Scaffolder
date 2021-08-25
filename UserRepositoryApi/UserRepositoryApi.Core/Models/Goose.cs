using System;

namespace UserRepositoryApi.Core.Models
{
    public class Goose : Bird
    {
        public override string Sound() {
            return "Honk!";
        }
    }
}
