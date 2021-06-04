using KEK_Emlak.Data.Entities;
using KEK_Emlak.Repo.Repository;
using KEK_Emlak.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Services
{
   public class SellService:ISellService
    {
        private readonly IRepository<Sell> SellRepository;
        public SellService( IRepository<Sell> SellRepository)
        {
            this.SellRepository = SellRepository;
        }

        public void DeleteSell(int id)
        {
            Sell Sell = SellRepository.Get(id);
            SellRepository.Delete(Sell);

        }

        public Sell GetSell(int id)
        {
            return SellRepository.Get(id);
        }

        public IEnumerable<Sell> GetSells()
        {
            return SellRepository.GetAll();
        }

        public void InsertSell(Sell Sell)
        {
            SellRepository.Insert(Sell);
        }

        public void UpdateSell(Sell Sell)
        {
            SellRepository.Update(Sell);
        }
        public int count()
        {
            return SellRepository.count();
        }

    }
}
