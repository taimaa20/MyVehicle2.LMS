using MyVehicle.LMS.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.CORE.Repoisitory
{
  public  interface ICardsRepoisitory
    {
        public bool InsertCards(Cards cards);
        public bool UpdateCards(Cards cards);
        public bool DeleteCards(Cards cards);
        public List<Cards> GetAllCards();
        public Cards GetCardById(Cards cards);
    }
}
