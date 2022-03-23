using Domain.Models;
using System.Collections.Generic;
using WoodnoteMobileUI.Models;

namespace WoodnoteMobileUI.Converters
{
    public static class ItemConverter
    {
        public static Item ToItemUI(this ItemDomain item)
        {
            return new Item()
            {
                Id = item.Id,
                Text = item.Text,
                Description = item.Description
            };
        }

        public static IEnumerable<Item> ToItemsUI(this IEnumerable<ItemDomain> items)
            => CollectionsConverter.ConvertCollection(items, ToItemUI);

        public static ItemDomain ToItemDomain(this Item item)
        {
            return new ItemDomain()
            {
                Id = item.Id,
                Text = item.Text,
                Description = item.Description
            };
        }

        public static IEnumerable<ItemDomain> ToItemsDomain(this IEnumerable<Item> items)
            => CollectionsConverter.ConvertCollection(items, ToItemDomain);
    }
}
