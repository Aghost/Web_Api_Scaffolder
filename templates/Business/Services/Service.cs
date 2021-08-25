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
        public ITEM GetITEM(int Id) {
            return _db.ITEMs.Find(Id);
        }

        // GET By Name
        public ITEM GetITEM(string Name) {
            return _db.ITEMs.FirstOrDefault(iTEM => iTEM.Name == Name);
        }

        // ADD
        public void AddITEM(ITEM iTEM) {
            _db.Add(iTEM);
            _db.SaveChanges();
        }

        // DELETE
        public void DeleteITEM(int Id) {
            var iTEMToDelete = _db.ITEMs.Find(Id);

            if (iTEMToDelete != null) {
                _db.Remove(iTEMToDelete);
            }

            throw new InvalidOperationException("no iTEMs exists");
        }
    }
}
