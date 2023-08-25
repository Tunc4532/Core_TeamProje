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
    public class UzmanEkipManager : IUzmanEkipService
    {
        IUzmanEkipDal _uzmanEkipDal;

        public UzmanEkipManager(IUzmanEkipDal uzmanEkipDal)
        {
            _uzmanEkipDal = uzmanEkipDal;
        }

        public void TAdd(UzmanEkip t)
        {
            _uzmanEkipDal.Insert(t);
        }

        public void TDelete(UzmanEkip t)
        {
            _uzmanEkipDal.Delete(t);
        }

        public UzmanEkip TGetByID(int id)
        {
            return _uzmanEkipDal.GetByID(id);
        }

        public List<UzmanEkip> TGetList(UzmanEkip t)
        {
           return _uzmanEkipDal.GetList();
        }

        public List<UzmanEkip>? TGetList()
        {
            return _uzmanEkipDal.GetList();
        }

        public List<UzmanEkip> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UzmanEkip t)
        {
           _uzmanEkipDal.Update(t);
        }
    }
}
