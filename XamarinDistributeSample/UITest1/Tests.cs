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
            app.WaitForElement(c => c.Text("HomePage:HockeyApp"));
            app.Screenshot("ScreenShot No.01");
            app.Tap(c => c.Text("メンバーリスト"));
            app.WaitForElement(c => c.Text("MemberList"));
            app.Screenshot("ScreenShot No.01");
            app.Tap(c => c.Text("Futamura Haruka"));
            app.Back();
            app.Screenshot("ScreenShot No.03");
            app.WaitForElement(c => c.Text("MemberList"));
            app.Tap(c => c.Text("Akane Takayanagi"));
            app.Back();
            app.Screenshot("ScreenShot No.04");
            app.WaitForElement(c => c.Text("MemberList"));
            app.Back();
            //app.Back();
        }
    }
}

