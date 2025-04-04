using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BUS_Nation
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public Dantoc getID(int id)
        {
            return db.Dantocs.FirstOrDefault(x => x.ID == id);
        }
        public List<Dantoc> getList()
        {
            return db.Dantocs.ToList();
        }
        public Dantoc Add(Dantoc dt)
        {
            try
            {
                db.Dantocs.Add(dt);
                db.SaveChanges();
                return dt;

            }
            catch(Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
        public Dantoc Update(Dantoc dt)
        {
            try
            {
                var _dt = db.Dantocs.FirstOrDefault(x => x.ID == dt.ID);
                _dt.TenDT = dt.TenDT;
                db.Dantocs.Add(dt);
                db.SaveChanges();
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _dt = db.Dantocs.FirstOrDefault(x => x.ID == id);
                db.Dantocs.Remove(_dt);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }

    }
}
