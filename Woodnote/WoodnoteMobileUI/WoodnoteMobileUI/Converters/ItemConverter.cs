using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WoodnoteMobileUI.Models;

namespace WoodnoteMobileUI.Converters
{
    public static class ItemConverter
    {
        public static Item ToItemUI(this Item_ item)
        {
            return new Item()
            {
                Id = item.Id,
                Text = item.Text,
                Description = item.Description
            };
        }

        public static IEnumerable<Item> ToItemsUI(this IEnumerable<Item_> items)
            => CollectionsConverter.ConvertCollection(items, ToItemUI);

        public static Item_ ToItemDomain(this Item item)
        {
            return new Item_()
            {
                Id = item.Id,
                Text = item.Text,
                Description = item.Description
            };
        }

        public static IEnumerable<Item_> ToItemsDomain(this IEnumerable<Item> items)
            => CollectionsConverter.ConvertCollection(items, ToItemDomain);
    }
}
