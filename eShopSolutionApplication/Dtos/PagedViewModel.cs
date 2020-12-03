using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolutions.Application.Dtos
{
    public class PagedViewModel<T>
    {
        List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
