using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public enum DiscountType
    {
        None,
        Senior,
        Child
    }
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private DiscountType discountType;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecChildDiscount = 10.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }


    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, DiscountType discountType)
    {
        Section = section;
        Quantity = quantity;
        this.discountType = discountType;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
         }
            switch (discountType)
            {
                case DiscountType.Senior:
                    mPrice -= mdecDiscount;
                    break;
                case DiscountType.Child:
                    mPrice -= mdecChildDiscount;
                    break;

            }

         AmountDue = mPrice * quantity;

     }
    }
}
