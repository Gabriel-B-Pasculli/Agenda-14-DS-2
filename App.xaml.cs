namespace Agenda13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PaginaContratacao());
            Routing.RegisterRoute("Sobre", typeof(Views.Sobre));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 780;

            return window;
        }
    }
}