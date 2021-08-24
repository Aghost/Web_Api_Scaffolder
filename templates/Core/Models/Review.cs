using System;

namespace PROJECTNAME.Core.Models {
    public class Review {
        public int Id { get; set; }
        public string ReviewName { get; set; }
        public string ReviewData { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
