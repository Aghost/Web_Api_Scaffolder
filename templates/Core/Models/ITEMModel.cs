using System;
using System.Linq;
using System.Collections.Generic;

namespace PROJECTNAME.Core.Models {
    public class ITEM  {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public List<CHILDITEM> CHILDITEMs { get; set; }
    }
}
