using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.iOS)]
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            //app.Repl();
            app.Screenshot("First screen.");
            app.WaitForElement(c => c.Button().Text("メンバーリスト"));
            app.Tap(c => c.Button().Text("メンバーリスト"));
            app.WaitForElement(c => c.Text("MemberList"));
            app.Screenshot("Second screen.");
            app.Tap(c => c.Text("二村春香"));
            app.Back();
            app.WaitForElement(c => c.Text("MemberList"));
            app.Tap(c => c.Text("高柳明音"));
            app.Back();
            app.WaitForElement(c => c.Text("MemberList"));
            app.Back();
            app.Back();
        }
    }
}

