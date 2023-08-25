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
    public class EkipTanitimManager : IEkipTanitimService
    {
        IEkipTanitimDal _ekipTanitimDal;

        public EkipTanitimManager(IEkipTanitimDal ekipTanitimDal)
        {
            _ekipTanitimDal = ekipTanitimDal;
        }

        public void TAdd(EkipTanitim t)
        {
           _ekipTanitimDal.Insert(t);
        }

        public void TDelete(EkipTanitim t)
        {
            _ekipTanitimDal.Delete(t);
        }

        public EkipTanitim TGetByID(int id)
        {
            return _ekipTanitimDal.GetByID(id);
        }

        public List<EkipTanitim> TGetList(EkipTanitim t)
        {
            return _ekipTanitimDal.GetList();
        }

        public List<EkipTanitim>? TGetList()
        {
            return _ekipTanitimDal.GetList();
        }

        public List<EkipTanitim> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EkipTanitim t)
        {
            _ekipTanitimDal.Update(t);
        }
    }
}
