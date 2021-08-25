using System.Collections.Generic;
using PROJECTNAME.Core.Models;

namespace PROJECTNAME.Business.Interfaces {
    public interface IITEMService {
        public List<ITEM> GetAllITEMs();
        public ITEM GetITEM(int id);
        public ITEM GetITEM(string name);
        public void AddITEM(string iTEMName);
        public void DeleteITEM(int id);
    }
}
