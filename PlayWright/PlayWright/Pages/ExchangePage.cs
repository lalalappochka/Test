using Microsoft.Playwright;
using PlayWright.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class ExchangePage : BasePage
    {
        public const string CurrencyDropdown = "asset-coin-select__bybutton";
        public const string FromCurrency = "li:has-text(\'USDT\'";
        public const string ToCurrency = "#popover-root >> text=BTC";
        public const string SendingField = ".by-input.by-input--readonly > .by-input__container > .by-input__wrapper";
        public const string ConvertButton = "button:has-text(\'Convert\'";
        public const string ConvertingSumm = ".exchange-result_content-line > .content";
        public const string ResultingConvertAmount = "ant-table-cell";

        public ExchangePage(IPage page) : base(page) { }

        public async Task<ExchangePage> OpenDropdownFromAsync()
        {
            await Page.Locator(CurrencyDropdown).Nth(1).ClickAsync();
            return this;
        }

        public async Task<ExchangePage> ChooseFromCurrencyAsync()
        {
            await Page.Locator(FromCurrency).ClickAsync();
            return this;
        }

        public async Task<ExchangePage> OpenDropdownToAsync()
        {
            await Page.Locator(CurrencyDropdown).Nth(6).ClickAsync();
            return this;
        }

        public async Task<ExchangePage> ChooseCurrencyToAsync()
        {
            await Page.Locator(ToCurrency).ClickAsync();
            return this;
        }

        public async Task<ExchangePage> ChooseAmountOfCurrencyAsync(int amount)
        {
            await Page.FillAsync(SendingField, amount.ToString());
            return this;
        } 

        public async Task<ExchangePage> ConvertCurrencyButAsyncAsync()
        {
            await Page.Locator(ConvertButton).ClickAsync();
            return this;
        }

        public async Task<string> CheckSummOfConvertAsync()
        {
            return await Page.Locator(ConvertingSumm).InnerTextAsync();
        }

        public async Task<string> LastConvertingAsync()
        {
            return await Page.Locator(ResultingConvertAmount).Nth(10).InnerTextAsync();
        }

    }
}
