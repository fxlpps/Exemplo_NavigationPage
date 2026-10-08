namespace Exemplo_NavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new MainPage())); //Cria uma nova janela com a Página Principal (MainPage) dentro de uma NavigationPage
        }
    }
}