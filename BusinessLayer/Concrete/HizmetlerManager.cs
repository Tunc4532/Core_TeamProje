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
    public class HizmetlerManager : IHizmetlerService
    {
        IHizmetlerDal _hizmetlerDal;

        public HizmetlerManager(IHizmetlerDal hizmetlerDal)
        {
            _hizmetlerDal = hizmetlerDal;
        }

        public void TAdd(Hizmetler t)
        {
            _hizmetlerDal.Insert(t);
        }

        public void TDelete(Hizmetler t)
        {
            _hizmetlerDal.Delete(t);
        }

        public Hizmetler TGetByID(int id)
        {
            return _hizmetlerDal.GetByID(id);
        }

        public List<Hizmetler> TGetList(Hizmetler t)
        {
            return _hizmetlerDal.GetList();
        }

        public List<Hizmetler>? TGetList()
        {
            return _hizmetlerDal.GetList();
        }

        public List<Hizmetler> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Hizmetler t)
        {
            _hizmetlerDal.Update(t);
        }
    }
}
