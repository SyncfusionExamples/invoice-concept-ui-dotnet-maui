using System;
using System.Collections.ObjectModel;
using InvoiceConceptUI.Models;

namespace InvoiceConceptUI.ViewModels
{
	public class ItemsViewModel
	{
        private ObservableCollection<ItemInfo> itemInfo;

		public ObservableCollection<ItemInfo> ItemInfo
		{
			get { return itemInfo; }
			set { this.itemInfo = value; }
		}
		internal void GenerateInfo()
		{
			itemInfo = new ObservableCollection<ItemInfo>();
            itemInfo.Add(new ItemInfo { Order = "01", Title = "Dashboard Design", Description = "Quantity: 3 pages", Price = "$1,025.27" });
            itemInfo.Add(new ItemInfo { Order = "02", Title = "Component Design & Ar...", Description = "Quantity: 1.5 hours", Price = "$145.92" });
		}
        public ItemsViewModel()
		{
			GenerateInfo();
		}
	}
}

