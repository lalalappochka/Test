using Microsoft.Playwright;
using PlayWright.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class SpotPage : BasePage
    {
        public const string DropdownDerivatives = "//span[text()='BIT/USDT']";
        public const string NewDerivative = "//span[text()='BTC']";
        public const string CurrentDerivative = "//*[@class='icon-currency']/following-sibling::span";
        public SpotPage(IPage page) : base(page) { }

        public async Task<SpotPage> FindDropdownDerivativesAsync()
        {
            await Page.HoverAsync(CurrentDerivative);
            return this;
        }

        public async Task<string> FindNewDerivativeAsync( )
        {
            return await Page.Locator(NewDerivative).InnerTextAsync();  
        }

        public async Task<SpotPage> ChooseNewDerivativeAsync()
        {
            await Page.Locator(NewDerivative).ClickAsync();
            return this;
        }

        public async Task<string> GetCurrentDerivativeAsync()
        {
            return await Page.Locator(CurrentDerivative).InnerTextAsync();
        }

    }
}
