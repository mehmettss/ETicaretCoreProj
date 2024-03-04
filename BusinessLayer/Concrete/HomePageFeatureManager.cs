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
    public class HomePageFeatureManager : IHomePageFeatureService
    {
        IHomePageFeatureDal _homePageFeatureDal;

        public HomePageFeatureManager(IHomePageFeatureDal homePageFeatureDal)
        {
            _homePageFeatureDal = homePageFeatureDal;
        }

        public HomePageFeature GetById(int id)
        {
          return _homePageFeatureDal.GetById(id);
        }

        public List<HomePageFeature> GetList()
        {
            return _homePageFeatureDal.GetList();
        }

        public void TAdd(HomePageFeature t)
        {
            _homePageFeatureDal.Insert(t);
        }

        public void TDelete(HomePageFeature t)
        {
            _homePageFeatureDal.Delete(t);
        }

        public void TUpdate(HomePageFeature t)
        {
            _homePageFeatureDal.Update(t);
        }
    }
}
