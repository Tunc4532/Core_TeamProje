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
    public class OneCikanManager : IGenericService<OneCikan>
    {
        IOneCikanDal _oneCikanDal;

        public OneCikanManager(IOneCikanDal oneCikanDal)
        {
            _oneCikanDal = oneCikanDal;
        }

        public void TAdd(OneCikan t)
        {
           _oneCikanDal.Insert(t);
        }

        public void TDelete(OneCikan t)
        {
            _oneCikanDal.Delete(t);
        }

        public OneCikan TGetByID(int id)
        {
            return _oneCikanDal.GetByID(id);
        }

        public List<OneCikan> TGetList(OneCikan t)
        {
            return _oneCikanDal.GetList();
        }

        public List<OneCikan>? TGetList()
        {
            return _oneCikanDal.GetList();
        }

        public List<OneCikan> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OneCikan t)
        {
            _oneCikanDal.Update(t);
        }
    }
}
