using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitFramework.Pages
{
    internal class LoginPage : BasePage
    {

        public LoginPage(IPage page) : base(page) { }

        public async Task<FirstPage> LoginAsAsync(string email, string password)
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.FillAsync("[placeholder='Email']", email);
            await Page.FillAsync("[placeholder='Password']", password);
            await Page.ClickAsync("a:has-text(\"Continue\")");
            return new FirstPage(Page);

        }
    }
}
