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
        public const string QuantityFieldForBuying = ".sfe-input-left__inner";
        public const string ConfirmBuyingButton = "//span[text()='Buy BTC']";
        public const string ConfirmSellButton = "//span[text()='Sell BTC']";
        public const string ConfirmLimitBuyWindow = ".el-button > .el-button--main > .is-plain >.flex-1";
        public const string TradeHistoryBuy = "//span[text()='Buy']";
        public const string SellSection = ".sell > .flex-1";

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

        public async Task<SpotPage> FindQuantityFieldAsync()
        {
            await Page.Locator(QuantityFieldForBuying).Nth(1).ClickAsync();
            return this;
        }

        public async Task<SpotPage> SendToQuantityFieldAsync(double amount)
        {
            await Page.FillAsync(QuantityFieldForBuying, amount.ToString());
            return this;
        }

        public async Task<SpotPage> ConfirmBTCBuyingAsync()
        {
            await Page.Locator(ConfirmBuyingButton).ClickAsync();
            return this;
        }

        public async Task<SpotPage> ConfirmLimitsAsync()
        {
            await Page.Locator(ConfirmLimitBuyWindow).ClickAsync();
            return this;
        }

        public async Task<double> CheckHistoryAmountAsync()
        {
            return Convert.ToDouble(Page.Locator(TradeHistoryBuy).Nth(10).InnerTextAsync());
        }

        public async Task<SpotPage> ChooseSellSectionAsync()
        {
            await Page.Locator(SellSection).ClickAsync();
            return this;
        }
        public async Task<SpotPage> ConfirmBTCSellingAsync()
        {
            await Page.Locator(ConfirmSellButton).ClickAsync();
            return this;
        }
    }
}
