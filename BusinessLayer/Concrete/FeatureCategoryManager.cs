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
    public class FeatureCategoryManager : IFeatureCategoryService
    {
        IFeatureCategoryDal _featureCategoryDal;

        public FeatureCategoryManager(IFeatureCategoryDal featureCategoryDal)
        {
            _featureCategoryDal = featureCategoryDal;
        }

        public FeatureCategory GetById(int id)
        {
            return _featureCategoryDal.GetById(id);
        }

        public List<FeatureCategory> GetList()
        {
           return _featureCategoryDal.GetList();
        }

        public void TAdd(FeatureCategory t)
        {
            _featureCategoryDal.Insert(t);
        }

        public void TDelete(FeatureCategory t)
        {
            _featureCategoryDal.Delete(t);
        }

        public void TUpdate(FeatureCategory t)
        {
            _featureCategoryDal.Update(t);
        }
    }
}
