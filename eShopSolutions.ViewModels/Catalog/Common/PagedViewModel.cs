using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutions.ViewModels.Catalog.Common
{
    public class PagedViewModel<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
