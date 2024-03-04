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
    public class BestSellingProductManager : IBestSellingProductService
    {
        IBestSellingProductDal _bestSellingProductDal;

        public BestSellingProductManager(IBestSellingProductDal bestSellingProductDal)
        {
            _bestSellingProductDal = bestSellingProductDal;
        }

        public BestSellingProduct GetById(int id)
        {
            return _bestSellingProductDal.GetById(id);
        }

        public List<BestSellingProduct> GetList()
        {
            return _bestSellingProductDal.GetList();
        }

        public void TAdd(BestSellingProduct t)
        {
            _bestSellingProductDal.Insert(t);
        }

        public void TDelete(BestSellingProduct t)
        {
            _bestSellingProductDal.Delete(t);
        }

        public void TUpdate(BestSellingProduct t)
        {
           _bestSellingProductDal.Update(t);
        }
    }
}
