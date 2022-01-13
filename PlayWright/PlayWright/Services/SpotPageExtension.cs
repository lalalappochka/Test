using BybitFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Services
{
    internal static class SpotPageExtension
    {
        public static async Task ByuingBTCOperation(this SpotPage page, double amount)
        {
            await page.FindQuantityFieldAsync().Result.SendToQuantityFieldAsync(amount).Result.ConfirmBTCBuyingAsync()
                      .Result.ConfirmLimitsAsync();
        }

        public static async Task SellingBTCOperation(this SpotPage page, double amount)
        {
            await page.ChooseSellSectionAsync().Result.FindQuantityFieldAsync().Result.SendToQuantityFieldAsync(amount).Result.ConfirmBTCSellingAsync()
                      .Result.ConfirmLimitsAsync();
        }
    }
}
