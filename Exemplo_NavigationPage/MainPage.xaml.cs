
using System.Threading.Tasks;

namespace Exemplo_NavigationPage
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object? sender, EventArgs e)
        {
            //PUSH: Navegar para a próxima página
            await Navigation.PushAsync(new SegundaPage());
        }
    }
}
