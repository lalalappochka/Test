using BybitFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWright.Services
{
    internal static class SpotPageExtension
    {
        public static async Task ChangeDerivative(this SpotPage page)
        {
           await page.FindDropdownDerivativesAsync().Result.ChooseNewDerivativeAsync();
        }
    }
}
