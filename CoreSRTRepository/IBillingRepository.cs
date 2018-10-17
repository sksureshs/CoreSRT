using CoreSRTModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreSRTRepository
{
    public interface IBillingRepository
    {
        void CreateItem(Item item);

        Item  GetItem(int itemId);

        IEnumerable<Item> GetAllItems(); 
    }
}
