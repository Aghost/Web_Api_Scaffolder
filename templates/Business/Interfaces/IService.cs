using System.Collections.Generic;
using PROJECTNAME.Core.Models;

namespace PROJECTNAME.Business.Interfaces {
    public interface IITEMService {
        public List<ITEM> GetAllITEMs();
        public ITEM GetITEM(int Id);
        public ITEM GetITEM(string Name);
        public void AddITEM(ITEM iTEM);
        public void DeleteITEM(int Id);
    }
}
