using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace aulauwp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();
            var RespostaJson = await client.GetStringAsync
                ("http://fcvwebapi.azurewebsites.net/api/Pessoas");
            var pessoasResultado = JsonConvert.DeserializeObject<List<Pessoa>>
                (RespostaJson);
            pessoasLista.ItemsSource = pessoasResultado;
        }

        private void adicionarButton_Click(object sender, 
            Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AdicionarPessoa));
        }
    }
}
