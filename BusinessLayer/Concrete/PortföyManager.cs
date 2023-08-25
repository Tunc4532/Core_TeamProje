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
    public class PortföyManager : IPortföyService
    {
        IPortföyDal _portföyDal;

        public PortföyManager(IPortföyDal portföyDal)
        {
            _portföyDal = portföyDal;
        }

        public void TAdd(Portföy t)
        {
            _portföyDal.Insert(t);
        }

        public void TDelete(Portföy t)
        {
            _portföyDal.Delete(t);
        }

        public Portföy TGetByID(int id)
        {
            return _portföyDal.GetByID(id);
        }

        public List<Portföy> TGetList(Portföy t)
        {
            return _portföyDal.GetList();
        }

        public List<Portföy>? TGetList()
        {
            return _portföyDal.GetList();
        }

        public List<Portföy> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portföy t)
        {
          _portföyDal.Update(t);
        }
    }
}
