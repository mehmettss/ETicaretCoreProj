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
    public class CartManager : ICartService
    {
        ICartDal _ICartService;

        public CartManager(ICartDal ıCartService)
        {
            _ICartService = ıCartService;
        }

        public Cart GetById(int id)
        {
            return _ICartService.GetById(id);
        }

        public List<Cart> GetList()
        {
            return _ICartService.GetList();
        }

        public void TAdd(Cart t)
        {
           _ICartService.Insert(t);
        }

        public void TDelete(Cart t)
        {
            _ICartService.Delete(t);
        }

        public void TUpdate(Cart t)
        {
            _ICartService.Update(t);
        }
    }
}
