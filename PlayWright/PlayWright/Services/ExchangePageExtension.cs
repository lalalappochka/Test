using BybitFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Services
{
    internal static class ExchangePageExtension
    {
        public static async Task ConvertOperation(this ExchangePage page, int amount)
        {
            await page.OpenDropdownFromAsync().Result.ChooseFromCurrencyAsync()
                .Result.OpenDropdownToAsync().Result.ChooseCurrencyToAsync()
                       .Result.ChooseAmountOfCurrencyAsync(amount).Result.ConvertCurrencyButAsyncAsync();

        }
    }
}
