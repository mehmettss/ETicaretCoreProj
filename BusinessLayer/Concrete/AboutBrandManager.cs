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
    public class AboutBrandManager : IAboutBrandService
    {
        IAboutBrandDal _aboutBrandDal;

        public AboutBrandManager(IAboutBrandDal aboutBrandDal)
        {
            _aboutBrandDal = aboutBrandDal;
        }

        public AboutBrands GetById(int id)
        {
           return _aboutBrandDal.GetById(id);
        }

        public List<AboutBrands> GetList()
        {
            return _aboutBrandDal.GetList();
        }

        public void TAdd(AboutBrands t)
        {
            _aboutBrandDal.Insert(t);
        }

        public void TDelete(AboutBrands t)
        {
            _aboutBrandDal.Delete(t);
        }

        public void TUpdate(AboutBrands t)
        {
            _aboutBrandDal.Update(t);
        }
    }
}
