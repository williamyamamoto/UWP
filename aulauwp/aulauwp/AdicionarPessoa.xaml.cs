using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Newtonsoft.Json;
using System.Net.Http;

namespace aulauwp
{
    public sealed partial class AdicionarPessoa : Page
    {
        public AdicionarPessoa()
        {
            this.InitializeComponent();
        }

        private async void adicionarButton_Click(object sender, RoutedEventArgs e)
        {
            var pessoa = new Pessoa()
            {
                Nome = pessoaNomeTextBox.Text,
                Sobrenome = pessoaSobreNomeTextBox.Text
            };
            var pessoaJson = JsonConvert.SerializeObject(pessoa);
            var client = new HttpClient();
            var HttpContent = new StringContent(pessoaJson);
            HttpContent.Headers.ContentType = 
                new System.Net.Http.Headers.MediaTypeHeaderValue
                ("application/json");
            await client.PostAsync
        ("http://fcvwebapi.azurewebsites.net/api/Pessoas", HttpContent);
        }
        private void cancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
