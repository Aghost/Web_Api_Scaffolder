using System;
using System.Linq;
using System.Collections.Generic;

namespace UserRepositoryApi.Core.Models {
    public class Movie {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public List<Review> Review { get; set; }
    }
}
