using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class MarketPage : BasePage
    {
        public MarketPage(IPage page) : base(page) { }

        public async void ChooseSpotAsync()
        {
            await Page.ClickAsync("span:has-text(\"Спот\")");
        }
    }
}
