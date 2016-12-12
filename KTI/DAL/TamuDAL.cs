using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KTI.Models;
namespace KTI.DAL
{
    public class TamuDAL : IDisposable
    {
        private BukuTamuModel db = new BukuTamuModel();

        public IQueryable<Tamu> GetDataTamu()
        {
            var result = from t in db.Tamus
                         orderby t.Nama_Tamu
                         select t;
            return result;
        }

        public void Add(Tamu obj)
        {
            try
            {
                db.Tamus.Add(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}