using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CevikEkipManager : ICevikEkipService
    {
        ICevikEkipDal _cevikEkipDal;

        public CevikEkipManager(ICevikEkipDal cevikEkipDal)
        {
            _cevikEkipDal = cevikEkipDal;
        }

        public void TAdd(CevikEkip t)
        {
           _cevikEkipDal.Insert(t);
        }

        public void TDelete(CevikEkip t)
        {
            _cevikEkipDal.Delete(t);
        }

        public CevikEkip TGetByID(int id)
        {
            return _cevikEkipDal.GetByID(id);
        }

        public List<CevikEkip> TGetList(CevikEkip t)
        {
            return _cevikEkipDal.GetList();
        }

        public List<CevikEkip>? TGetList()
        {
            return _cevikEkipDal.GetList();
        }

        public List<CevikEkip> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CevikEkip t)
        {
           _cevikEkipDal.Update(t);
        }
    }
}
