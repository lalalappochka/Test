using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BybitFramework.Models;
using BybitFramework.Pages;
using BybitFramework.Services;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace BybitFramework
{
    internal class Test
    {
        private string userEmail = "lalalappochka@gmail.com";
        private string userPassword = "P@ssw0rd";
        private IPage _page;
        private string pageURL = "https://testnet.bybit.com/";
        [OneTimeSetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            { Channel = "chrome", Headless = false });
            _page = await browser.NewPageAsync();
            await _page.GotoAsync(pageURL);
        }

        [Test]
        [TestCase(10)]
        public async Task ByBitTestTransfer(double amount)
        {
            FirstPage firstPage = new FirstPage(_page);
            LoginPage loginPage = await firstPage.MoveToLoginPageAsync();
            firstPage = await loginPage.LoginAsAsync(userEmail, userPassword);
            AssetsPage assetsPage = await firstPage.MoveToAssestsPageAsync();

            AssetTransfer assetTransfer = new AssetTransfer();
            ////assetTransfer.CashBeforeTransferOperation = assetsPage.CashBeforeTransferAsync();
            await assetsPage.TransferOperationAsync(amount);
            ////assetTransfer.CashAfterTransferOperation = assetsPage.CashAmountAfterTransferAsync();

            //Assert.AreEqual(assetTransfer.CashBeforeTransferOperation, assetTransfer.CashAfterTransferOperation - amount);


        }

    }
}
