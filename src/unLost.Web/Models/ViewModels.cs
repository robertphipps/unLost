using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace unLost.Web.Models
{
    public class ViewModels
    {
        public class ListItemsModel
        {
            public string mode { get; set; }
            public IQueryable<Item> items { get; set; }

            public ListItemsModel(string mode, IQueryable<Item> items)
            {
                this.mode = mode;
                this.items = items;
            }
        }
    }
}
