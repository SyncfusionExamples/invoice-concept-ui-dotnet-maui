using System;
namespace InvoiceConceptUI.Models
{
    public class ItemInfo
    {
        private string order;
        private string title;
        private string description;
        private string price;

        public string Order
        {
            get { return order; }
            set { order = value;   } 
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

