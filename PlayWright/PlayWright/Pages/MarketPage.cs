using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class MarketPage : BasePage
    {
        public MarketPage(IPage page) : base(page) { }

        public async Task<MarketPage> ChooseSpotAsync()
        {
            await Page.ClickAsync("text = FavoritesDerivativesSpotNEWReferences >> :nth-match(div, 3)");
            return this;
        }

        public async Task<MarketPage> AddToFavButAsync()
        {
            await Page.ClickAsync("text=ETH/USDT3,928.69-1.78%4,000.0025.00229.86K(USDT)Trade >> img");
            return this;
        }

        public async Task<MarketPage> ChooseFavSectionAsync()
        {
            await Page.ClickAsync("text=FavoritesDerivativesSpotNEWReferences >> div");
            return this;
        }

        public async Task<MarketPage> ChooseUnderFavSectionSpotAsync()
        {
            await Page.ClickAsync(":nth-match(:text(\"Spot\"), 3)");
            return this;
        }

        public async Task<string> CheckMarketsAsync()
        {
           string result = await Page.TextContentAsync("text=ETH/USDT3,928.69-1.78%4,000.0025.00229.86K(USDT)Trade");
           return result;
        }



    }
}
