using System;
using System.Linq;
using System.Collections.Generic;
using PROJECTNAME.Data;
using PROJECTNAME.Core.Models;

namespace PROJECTNAME.Business
{
    public class ITEMService : IITEMService
    {
        private readonly PROJECTNAMEDbContext _db;

        public ITEMService(PROJECTNAMEDbContext db) {
            _db = db;
        }

        public List<ITEM> GetAllITEMs() {
            return _db.ITEMs.ToList();
        }

        public ITEM GetITEM(int Id) {
            //OR var ITEM = _db.ITEMs.FirstOrDefault(iTEM => iTEM.Id == Id);
            return _db.ITEMs.Find(Id);
        }

        public void AddITEM(ITEM iTEM) {
            _db.Add(iTEM);
            _db.SaveChanges();
        }

        public void DeleteITEM(int Id) {
            var iTEMToDelete = _db.ITEMs.Find(Id);
            if (iTEMToDelete != null) {
                _db.Remove(iTEMToDelete);
            }
            throw new InvalidOperationException("no iTEMs exists");
        }
    }
}
