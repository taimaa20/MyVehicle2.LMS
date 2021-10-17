using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
   public  interface IBankCardRepoisitory
    {
        public List<BankCard> GetAllBankCard();

        public bool InsertBankCard(BankCard bankCard);
        public bool UpdateBankCard(BankCard bankCard);
        public bool DeleteBankCard(BankCard bankCard);
        public BankCard GetBankCardById(BankCard bankCard);
    }
}
