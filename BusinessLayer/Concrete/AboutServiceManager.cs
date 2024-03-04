using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutServiceManager : IAboutServiceService
    {
        IAboutServiceDal _aboutServiceDal;

        public AboutServiceManager(IAboutServiceDal aboutServiceDal)
        {
            _aboutServiceDal = aboutServiceDal;
        }

        public AboutService GetById(int id)
        {
            return _aboutServiceDal.GetById(id);
        }

        public List<AboutService> GetList()
        {
            return _aboutServiceDal.GetList();
        }

        public void TAdd(AboutService t)
        {
            _aboutServiceDal.Insert(t);
        }

        public void TDelete(AboutService t)
        {
            _aboutServiceDal.Delete(t);
        }

        public void TUpdate(AboutService t)
        {
           _aboutServiceDal.Update(t);
        }
    }
}
