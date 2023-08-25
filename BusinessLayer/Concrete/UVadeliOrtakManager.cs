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
    public class UVadeliOrtakManager : IUVadeliOrtakService
    {
        IUVadeliOrtakDal _uVadeliOrtakDal;

        public UVadeliOrtakManager(IUVadeliOrtakDal uVadeliOrtakDal)
        {
            _uVadeliOrtakDal = uVadeliOrtakDal;
        }

        public void TAdd(UVadeliOrtak t)
        {
            _uVadeliOrtakDal.Insert(t);
        }

        public void TDelete(UVadeliOrtak t)
        {
            _uVadeliOrtakDal.Delete(t);
        }

        public UVadeliOrtak TGetByID(int id)
        {
            return _uVadeliOrtakDal.GetByID(id);
        }

        public List<UVadeliOrtak> TGetList(UVadeliOrtak t)
        {
            return _uVadeliOrtakDal.GetList();
        }

        public List<UVadeliOrtak>? TGetList()
        {
            return _uVadeliOrtakDal.GetList();
        }

        public List<UVadeliOrtak> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UVadeliOrtak t)
        {
            _uVadeliOrtakDal.Update(t);
        }
    }
}
