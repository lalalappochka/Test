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
        public const string EnterEmail = "[placeholder='Email']";
        public const string EnterPassword = "[placeholder='Password']";
        public const string ContinueButton = "a:has-text(\"Continue\")";
        public LoginPage(IPage page) : base(page) { }

        public async Task<FirstPage> LoginAsAsync(string email, string password)
        {
            await Page.WaitForLoadStateAsync(LoadState.DOMContentLoaded);
            await Page.FillAsync(EnterEmail, email);
            await Page.FillAsync(EnterEmail, password);
            await Page.ClickAsync(ContinueButton);
            return new FirstPage(Page);

        }
    }
}
