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
            await Page.ClickAsync(".header__nav-item-markets");
            return new MarketPage(Page);
        }

        public async Task<AssetsPage> MoveToAssestsPageAsync()
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.ClickAsync("//span[text()='Assets']");
            await Page.ClickAsync("//*[text()='Spot Account']");
            return new AssetsPage(Page);
        }
    }
}
