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
            await Page.HoverAsync(DropdownDerivatives);
            return this;
        }

        public async Task<SpotPage> ChooseNewDerivativeAsync()
        {
            await Page.ClickAsync(NewDerivative);
            return this;
        }

        public async Task<string> GetCurrentDerivativeAsync()
        {
            return Convert.ToString(Page.TextContentAsync(CurrentDerivative));

        }

    }
}
