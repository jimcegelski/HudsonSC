using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://stefanroock.wordpress.com/2011/03/04/red-pencil-code-kata/

namespace Red_Pencil_Promotions
{
    public class Product
    {
        private double _currentPrice;
        private DateTime _currentPriceEffectiveDate;
        private bool _isRedPencil;

        public bool IsRedPencil { get { return _isRedPencil && RedPencilPromotionIs30DaysOldOrLess(); } }

        public void SetPrice(double newPrice, DateTime priceEffectiveDate)
        {
            _isRedPencil = SetIsRedPencil(newPrice, priceEffectiveDate);
            _currentPrice = newPrice;
            _currentPriceEffectiveDate = priceEffectiveDate;
        }

        private bool SetIsRedPencil(double newPrice, DateTime newPriceEffectiveDate)
        {
            if (_currentPriceEffectiveDate == DateTime.MinValue) return false;
            if (newPrice < _currentPrice) return false;
            
            var diff = _currentPrice - newPrice;
            var percentDifference = (diff / _currentPrice) * 100;
            if (percentDifference < 5) return false;
            if (percentDifference > 30) return false;

            if (!CurrentPriceIsAtLeast30DaysOld(newPriceEffectiveDate)) return false;

            return true;
        }

        private bool CurrentPriceIsAtLeast30DaysOld(DateTime newPriceEffectiveDate)
        {
            var span = newPriceEffectiveDate - _currentPriceEffectiveDate;
            if (span.Days < 30) return false;
            return true;
        }

        private bool RedPencilPromotionIs30DaysOldOrLess()
        {
            var span = DateTime.Now - _currentPriceEffectiveDate;
            if (span.Days > 30) return false;
            return true;
        }
    }
}
