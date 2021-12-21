using NUnit.Framework;
using Xamarin.UITest;

namespace UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
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
            app.Screenshot("First screen.");
        }

        [Test]
        public void NavigateToSecondPage()
        {
            /* Repl opens a conskole window to test UITest commands.
             * Writing on console app. intellicense shows options.
             * With "tree" command is possible to see all components in the page.
            */
            //app.Repl();

            //Marked find elements by Id, Content-desc or Text
            app.Tap(x => x.Marked("Next Page"));
            app.Screenshot("Second page");
            app.Back();
        }

        [Test]
        public void ChangeSliderValue()
        {            
            app.SetSliderValue(x => x.Marked("slider"), 25.55);
            app.Query(x => x.Marked("sliderText").Property("Text").Contains("25.55"));
            app.Screenshot("Slider test");            
        }
    }
}
