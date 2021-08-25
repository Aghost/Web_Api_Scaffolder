using System;

namespace UserRepositoryApi.Core.Models {
    public class UserFile {
        public int Id { get; set; }
        public string UserFileName { get; set; }
        public string UserFileData { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
