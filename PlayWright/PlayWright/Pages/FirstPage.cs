using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class FirstPage : BasePage
    {
        public const string ChooseHeaderFieldLogin = ".header-login";
        public const string MarketPageUrl = "https://testnet.bybit.com/data/markets/spot";
        public const string AssetsPageUrl = "https://testnet.bybit.com/user/assets/home";
        public const string SpotPageUrl = "https://testnet.bybit.com/en-US/trade/spot/BTC/USDT";
        public const string ExchangePageUrl= "https://testnet.bybit.com/user/assets/exchange/index";

        public FirstPage(IPage page) : base(page) { }

        public async Task<LoginPage> MoveToLoginPageAsync()
        {
            await Page.ClickAsync(ChooseHeaderFieldLogin);
            return new LoginPage(Page);
        }
        public async Task<MarketPage> MoveToMarketPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync(MarketPageUrl);
            return new MarketPage(Page);
        }
        public async Task<AssetsPage> MoveToAssestsPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync(AssetsPageUrl);
            return new AssetsPage(Page);
        }

        public async Task<SpotPage> MoveToSpotPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync(SpotPageUrl);
            return new SpotPage(Page);
        }

        public async Task<ExchangePage> MoveToExchangePage()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync(ExchangePageUrl);
            return new ExchangePage(Page);
        }

    }
}
