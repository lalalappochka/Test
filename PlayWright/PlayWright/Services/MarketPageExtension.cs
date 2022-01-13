using BybitFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Services
{
    internal static class MarketPageExtension
    {
        public static async Task ChooseFavouriteOperation(this MarketPage page)
        {
            await page.AddToFavButAsync();
            await page.ChooseFavSectionAsync();
            await page.ChooseUnderFavSectionSpotAsync();
        }
    }
}
