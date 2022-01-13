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
        public const string SpotToAdd = "text = FavoritesDerivativesSpotNEWReferences";
        public const string ChoosenSpot = "text=ETH/USDT3";
        public const string ChoosenSpotStar = "text=ETH/USDT3 >> img";
        public const string FavSection = "text=FavoritesDerivativesSpotNEWReferences";
        public const string UnderSection = ":nth-match(:text(\"Spot\"), 3)";
        public const string ChekedMarket = ".markets-tbody__item > .f-14 > .nowrap markets-tbody__item-symbol";
        public MarketPage(IPage page) : base(page) { }

        public async Task<MarketPage> ChooseSpotAsync()
        {
            await Page.Locator(SpotToAdd).ClickAsync();
            return this;
        }

        public async Task<string> FindSpotToAddAsync()
        {
            return await Page.Locator(ChoosenSpot).InnerTextAsync();
        }

        public async Task<MarketPage> AddToFavButAsync()
        {
            await Page.Locator(ChoosenSpotStar).ClickAsync();
            return this;
        }

        public async Task<MarketPage> ChooseFavSectionAsync()
        {
            await Page.Locator(FavSection).ClickAsync();
            return this;
        }

        public async Task<MarketPage> ChooseUnderFavSectionSpotAsync()
        {
            await Page.Locator(UnderSection).ClickAsync();
            return this;
        }

        public async Task<string> CheckMarketsAsync()
        {
            return await Page.Locator(ChekedMarket).InnerTextAsync();
        }



    }
}
