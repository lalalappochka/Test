using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class AssetsPage : BasePage
    {
        public AssetsPage(IPage page) : base(page) { }

        public async Task<AssetsPage> TransferButAsync()
        {
            await Page.ClickAsync("[@ant-click-animating-without-extra-node='false']");
            return this;
        }
        public async Task<AssetsPage> SenderAccountAsync()
        {
            await Page.Locator(".asset-transfer__account > .asset-transfer__account-wraper").ClickAsync();
            return this;
        }
        public async Task<AssetsPage> ChooseSenderAccountAsync()
        {
            await Page.Locator("//div[text()='Спот Аккаунт']").ClickAsync();
            return this;
        }

        //public async Task<AssetsPage> ReceiveAccountAsync()
        //{
        //    return this;
        //}
        public async Task<AssetsPage> ChooseReceiverAccountAsync()
        {
            await Page.Locator("//div[text()='Derivatives Account']").ClickAsync();
            return this;
        }
        public async Task<AssetsPage> OpenChooseCoinTypeAsync()
        {
            await Page.Locator(".by-select-adv-selection-search-input").ClickAsync();
            return this;
        }

        //public async Task<AssetsPage> ChooseCoinTypeAsync()
        //{
        //    return this;
        //}
        public async Task<AssetsPage> ChooseTransferableAmountAsync(double amount)
        {
            await Page.FillAsync(".by-input__inner", amount.ToString());
            return this;
        }
        public async Task<AssetsPage> ConfirmAsync()
        {
            await Page.ClickAsync("by-button--contained");
            return this;
        }

        //public async Task<double> CashAmountAfterTransferAsync()
        //{

        //    return 

        //}
    }
}
