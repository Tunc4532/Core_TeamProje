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
    public class BizimleCalisinManager : IBizimleCalisinService
    {
        IBizimleCalisinDal _bizimleCalisinDal;

        public BizimleCalisinManager(IBizimleCalisinDal bizimleCalisinDal)
        {
            _bizimleCalisinDal = bizimleCalisinDal;
        }

        public void TAdd(BizimleCalisin t)
        {
           _bizimleCalisinDal.Insert(t);
        }

        public void TDelete(BizimleCalisin t)
        {
            _bizimleCalisinDal.Delete(t);
        }

        public BizimleCalisin TGetByID(int id)
        {
            return _bizimleCalisinDal.GetByID(id);
        }

        public List<BizimleCalisin> TGetList(BizimleCalisin t)
        {
            return _bizimleCalisinDal.GetList();
        }

        public List<BizimleCalisin>? TGetList()
        {
            return _bizimleCalisinDal.GetList();
        }

        public List<BizimleCalisin> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(BizimleCalisin t)
        {
            _bizimleCalisinDal.Update(t);
        }
    }
}
