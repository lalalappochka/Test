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
        public FirstPage(IPage page) : base(page) { }

        public async Task<LoginPage> MoveToLoginPageAsync()
        {
            await Page.ClickAsync(".header-login");
            return new LoginPage(Page);
        }
        public async Task<MarketPage> MoveToMarketPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync("https://testnet.bybit.com/data/markets/spot");
            return new MarketPage(Page);
        }

        public async Task<AssetsPage> MoveToAssestsPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.GotoAsync(url: "https://testnet.bybit.com/user/assets/home");
            return new AssetsPage(Page);
        }
    }
}
