using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class Trinhdo
    {
        QLNhanSuEntities db = new QLNhanSuEntities();
        public List<TrinhDo> GetList()
        {
            return db.TrinhDoes.ToList();
        }
    }
}
