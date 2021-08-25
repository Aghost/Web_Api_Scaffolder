using System;
using System.Linq;
using System.Collections.Generic;
using PROJECTNAME.Data;
using PROJECTNAME.Core.Models;
using PROJECTNAME.Business.Interfaces;

namespace PROJECTNAME.Business.Services
{
    public class ITEMService : IITEMService
    {
        private readonly PROJECTNAMEDbContext _db;

        public ITEMService(PROJECTNAMEDbContext db) {
            _db = db;
        }

        // GET ALL
        public List<ITEM> GetAllITEMs() {
            return _db.ITEMs.ToList();
        }

        // GET 1
        public ITEM GetITEM(int id) {
            return _db.ITEMs.Find(id);
        }

        // GET By Name
        public ITEM GetITEM(string name) {
            return _db.ITEMs.FirstOrDefault(iTEM => iTEM.Name == name);
        }

        // ADD
        public void AddITEM(string iTEMname) {
            var iTEM = new ITEM() { Name = iTEMname };

            _db.Add(iTEM);
            _db.SaveChanges();
        }

        // DELETE
        public void DeleteITEM(int id) {
            var iTEMToDelete = _db.ITEMs.Find(id);

            if (iTEMToDelete != null) {
                _db.Remove(iTEMToDelete);
            } else {
                throw new InvalidOperationException("no iTEMs exists");
            }
        }
    }
}
