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
using PlayWright.Helpers;
using PlayWright.Logger;

namespace BybitFramework
{
    internal class Test : Logging
    {
        private static IBrowserContext _context;
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
            _context = await browser.NewContextAsync(new BrowserNewContextOptions
            { StorageStatePath = "..\\..\\..\\..\\auth.json" });
            _page = await _context.NewPageAsync();
            await _page.GotoAsync(pageURL);
        }

        [Test]
        [TestCase(0.1)]
        public async Task ByBitTestTransfer(double amount)
        {
            FirstPage firstPage = new FirstPage(_page);
            AssetsPage assetsPage = await firstPage.MoveToAssestsPageAsync().Result.TransferButAsync();
            AssetTransfer assetTransfer = new AssetTransfer();
            //assetTransfer.CashBeforeTransferOperation = await assetsPage.GetCash(TransferSideSelection.RECIEVER);
            //await assetsPage.TransferOperationAsync(amount);
            //assetTransfer.CashAfterTransferOperation = await assetsPage.GetCash(TransferSideSelection.RECIEVER);
            //Assert.AreEqual(assetTransfer.CashBeforeTransferOperation, assetTransfer.CashAfterTransferOperation - amount);
        }

        [Test]
        public async Task AddToFavourites()
        {
            FirstPage firstPage = new FirstPage(_page);
            MarketPage marketPage = await firstPage.MoveToMarketPageAsync();
            //await marketPage.ChooseSpotAsync();
            //string findSpot = await marketPage.FindSpotToAddAsync();
            //await marketPage.ChooseFavouriteOperation();
            //string addedSpot = await marketPage.CheckMarketsAsync();
            //Assert.AreEqual(findSpot, addedSpot);

        }

        [Test]
        public async Task ChangeDerivative()
        {
            FirstPage firstPage = new FirstPage(_page);
            SpotPage spotPage = await firstPage.MoveToSpotPageAsync();
            await spotPage.FindDropdownDerivativesAsync();
            //string futureDerivate = await spotPage.FindNewDerivativeAsync();
            //await spotPage.ChooseNewDerivativeAsync();
            //string curretnDerivative = await spotPage.GetCurrentDerivativeAsync();
            //Assert.AreEqual(futureDerivate,curretnDerivative);
        }

        [Test]
        [TestCase(1)]
        public async Task ExchangeCurrencyTransfer(int amount)
        {
            FirstPage firstPage = new FirstPage(_page);
            ExchangePage exchangePage = await firstPage.MoveToExchangePage();
            //await exchangePage.ConvertOperation(amount);
            //string checksumm = await exchangePage.CheckSummOfConvertAsync();
            //string lastconvert = await exchangePage.LastConvertingAsync();
            //Assert.AreEqual(checksumm, lastconvert);
        }

         [Test]
         [TestCase(0.2)]
         public async Task BuyBTC(double amount)
        {
            FirstPage firstPage = new FirstPage(_page);
            SpotPage spotPage = await firstPage.MoveToSpotPageAsync();
            //await spotPage.ByuingBTCOperation(amount);
            //double quantity = await spotPage.CheckHistoryAmountAsync();
            //Assert.AreEqual(amount, quantity);
        }

        [Test]
        [TestCase(0.2)]
        public async Task SellBTC(double amount)
        {
            FirstPage firstPage = new FirstPage(_page);
            SpotPage spotPage = await firstPage.MoveToSpotPageAsync();
            //await spotPage.SellingBTCOperation(amount);
            //double quantity = await spotPage.CheckHistoryAmountAsync();
            //Assert.AreEqual(amount, quantity);
        }
    }
}
