using KEK_Emlak.Data.Entities;
using KEK_Emlak.Repo.Repository;
using KEK_Emlak.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Services
{
   public class BuyService:IBuyService
    {
        private readonly IRepository<Buy> BuyRepository;
        public BuyService( IRepository<Buy> BuyRepository)
        {
            this.BuyRepository = BuyRepository;
        }

        public void DeleteBuy(int id)
        {
            Buy Buy = BuyRepository.Get(id);
            BuyRepository.Delete(Buy);

        }

        public Buy GetBuy(int id)
        {
            return BuyRepository.Get(id);
        }

        public IEnumerable<Buy> GetBuys()
        {
            return BuyRepository.GetAll();
        }

        public void InsertBuy(Buy Buy)
        {
            BuyRepository.Insert(Buy);
        }

        public void UpdateBuy(Buy Buy)
        {
            BuyRepository.Update(Buy);
        }
        public int count()
        {
            return BuyRepository.count();
        }

    }
}
