using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
    public class CardService : ICardService
    {
        private readonly ICardsRepoisitory cardsRepoisitory;
        public CardService(ICardsRepoisitory cardsRepoisitory)
        {
            this.cardsRepoisitory = cardsRepoisitory;
        }
        public bool DeleteCards(Cards cards)
        {
            return cardsRepoisitory.DeleteCards(cards);
        }

        public List<Cards> GetAllCards()
        {
            return cardsRepoisitory.GetAllCards();
        }

        public Cards GetCardById(Cards cards)
        {
            return cardsRepoisitory.GetCardById(cards);
        }

        public bool InsertCards(Cards cards)
        {
            return cardsRepoisitory.InsertCards(cards);

        }

        public bool UpdateCards(Cards cards)
        {
            return cardsRepoisitory.UpdateCards(cards);
        }
    }
}
