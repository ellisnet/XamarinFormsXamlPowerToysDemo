namespace XamarinFormsXamlPowerToysDemo {
    using Xamarin.Forms;
    using XamarinFormsXamlPowerToysDemo.View;

    public class App : Application {

        public App() {
            MainPage = new PersonEditorView();
        }

        protected override void OnResume() {
        }

        protected override void OnSleep() {
        }

        protected override void OnStart() {
        }

    }
}
