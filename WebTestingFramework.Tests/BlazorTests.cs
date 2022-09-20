using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;

namespace WebTestingFramework.Tests
{
    public class BlazorTests
    {
        private IPage page;

        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
            var context = await browser.NewContextAsync();
            page = await context.NewPageAsync();
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            // await context.CloseAsync();
        }

        [Test]
        public async Task test1()
        {
            await page.GotoAsync("https://www.saucedemo.com/");

            await page.FillAsync("#user-name", "standard_user");
            await page.FillAsync("#password", "secret_sauce");
            await page.ClickAsync("#login-button");
        }

        [Test]
        public async Task test2()
        {
            await page.GotoAsync("https://www.saucedemo.com/");

            await page.FillAsync("#user-name", "standard_user");
            await page.FillAsync("#password", "secret_sauce");
            await page.ClickAsync("#login-button");
        }

        [Test]
        public async Task test3()
        {
            await page.GotoAsync("https://www.saucedemo.com/");

            await page.FillAsync("#user-name", "standard_user");
            await page.FillAsync("#password", "secret_sauce");
            await page.ClickAsync("#login-button");
        }

        [Test]
        public async Task test4()
        {
            await page.GotoAsync("https://www.saucedemo.com/");

            await page.FillAsync("#user-name", "standard_user");
            await page.FillAsync("#password", "secret_sauce");
            await page.ClickAsync("#login-button");
        }
    }
}