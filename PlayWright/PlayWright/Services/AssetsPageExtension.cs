using BybitFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Services
{
    internal static class AssetsPageExtension
    {
        public static async Task TransferOperationAsync(this AssetsPage page, double amount)
        {
            await page.SenderAccountAsync();
            await page.ChooseSenderAccountAsync();
            await page.ReceiveAccountAsync();
            await page.ChooseReceiverAccountAsync();
            await page.OpenChooseCoinTypeAsync();
            await page.ChooseCoinTypeAsync();
            await page.ChooseTransferableAmountAsync(amount);
            await page.ConfirmAsync();
            //Thread.Sleep(5000);
        }
    }
}
