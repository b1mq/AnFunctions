using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAn.Domain.Entities
{
    public class CreditCard
    {
        public readonly Owner CardOwner;
        public readonly ExpiryDate Card_date;
        public readonly long CardNumber;
        private int _pinCode;
        private decimal _amount = 0;
        public event Action<string> OnAmountMatched;
        private decimal GivenAmountOfMoney { get; set; }
        public CreditCard(Owner cardOwner, ExpiryDate card_Date, int cardNumber)
        {
            CardOwner = cardOwner;
            Card_date = card_Date;
            CardNumber = cardNumber;
        }
        public void SetPinCode (int pincode)
        {
            if(pincode <= 9999 && pincode >= 0000)
            {
                _pinCode = pincode;
            }
        }
        public void SetAmount(decimal amount)
        {
            if( amount >= 0)
            {
                _amount = amount;
                if(_amount >= GivenAmountOfMoney )
                {
                    OnAmountMatched?.Invoke($"Amount is succesfully more than : {GivenAmountOfMoney} $ ");
                    GivenAmountOfMoney *= 2;
                }
            }
            else
            {
                throw new ArgumentException("Amount can not be negative");
            }

        }

        public void Withdraw(decimal amount)
        {
            if(_amount - amount >= 0)
            {
                _amount -= amount;
            }else
            {
                throw new ArgumentException("Amount can not be negative");
            }

        }


    }
}
