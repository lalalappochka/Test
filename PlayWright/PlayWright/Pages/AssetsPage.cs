using Microsoft.Playwright;
using PlayWright.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class AssetsPage : BasePage
    {
        public const string TransferButton = "button:has-text(\"Transfer\")";
        public const string SenderDropdownOpen = ".asset-transfer__account > .asset-transfer__account-wraper";
        public const string ChooseSender = "//div[text()='Spot Account']";
        public const string ChooseReceiver = "//div[text()='Derivatives Account']";
        public const string CoinDropdownOpen = ".by-select-adv-selection-search-input";
        public const string TransferableField = ".by-input__inner";
        public const string ConfirmButton = ".by-button";
        public AssetsPage(IPage page) : base(page) { }

        public async Task<AssetsPage> TransferButAsync()
        {
            await Page.ClickAsync(TransferButton);
            return this;
        }
        public async Task<AssetsPage> SenderAccountAsync()
        {
            await Page.Locator(SenderDropdownOpen).Nth(1).ClickAsync();
            return this;
        }

        public async Task<AssetsPage> ChooseSenderAccountAsync()
        {
            await Page.Locator(ChooseSender).ClickAsync();
            return this;
        }

        public async Task<AssetsPage> ReceiveAccountAsync()
        {
            return this;
        }
        public async Task<AssetsPage> ChooseReceiverAccountAsync()
        {
            await Page.Locator(ChooseReceiver).ClickAsync();
            return this;
        }
        public async Task<AssetsPage> OpenChooseCoinTypeAsync()
        {
            await Page.Locator(CoinDropdownOpen).ClickAsync();
            return this;
        }

        public async Task<AssetsPage> ChooseCoinTypeAsync()
        {
            return this;
        }
        public async Task<AssetsPage> ChooseTransferableAmountAsync(double amount)
        {
            await Page.FillAsync(TransferableField, amount.ToString());
            return this;
        }
        public async Task<AssetsPage> ConfirmAsync()
        {
            await Page.ClickAsync(ConfirmButton);
            return this;
        }

        public async Task<double> GetCash(TransferSideSelection account)
        {
            switch (account)
            {
                case TransferSideSelection.SENDER:
                    return Convert.ToDouble(await Page.Locator(".asset-transfer__account-value").Nth(1).InnerTextAsync());
                case TransferSideSelection.RECIEVER:
                    return Convert.ToDouble(await Page.Locator(".asset-transfer__account-value").Nth(2).InnerTextAsync());
                default:
                    return 0.0;
            }
        }
    }
}
