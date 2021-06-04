using KEK_Emlak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Interface
{
   public interface IBuyService
    {
        IEnumerable<Buy> GetBuys();
        Buy GetBuy(int id);
        void InsertBuy(Buy Buy);
        void UpdateBuy(Buy Buy);
        void DeleteBuy(int id);
        int count();
    }
}
