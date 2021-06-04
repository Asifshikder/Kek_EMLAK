using KEK_Emlak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Interface
{
   public interface ISellService
    {
        IEnumerable<Sell> GetSells();
        Sell GetSell(int id);
        void InsertSell(Sell Sell);
        void UpdateSell(Sell Sell);
        void DeleteSell(int id);
        int count();
    }
}
