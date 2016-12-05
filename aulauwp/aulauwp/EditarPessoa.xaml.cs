using Windows.UI.Xaml.Controls;
using Newtonsoft.Json;
using System.Net.Http;
using Windows.UI.Xaml.Navigation;

namespace aulauwp
{
    public sealed partial class EditarPessoa : Page
    {
        private Pessoa pessoa = new Pessoa();

        public EditarPessoa()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pessoa = e.Parameter as Pessoa;

            pessoaNomeTextBox.Text = pessoa.Nome;
            pessoaSobreNomeTextBox.Text = pessoa.Sobrenome;
        }

        private async void alterarButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var client = new HttpClient();

            pessoa.Nome = pessoaNomeTextBox.Text;

            pessoa.Sobrenome = pessoaSobreNomeTextBox.Text;

            var pessoaJson = JsonConvert.SerializeObject(pessoa);

            var HttpContent = new StringContent(pessoaJson);

            HttpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            await client.PutAsync("http://fcvwebapi.azurewebsites.net/api/Pessoas" + pessoa.Id, HttpContent);

            Frame.GoBack();
        }

        private async void excluirButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var client = new HttpClient();

            await client.DeleteAsync("http://fcvwebapi.azurewebsites.net/api/Pessoas" + pessoa.Id);

            Frame.GoBack();
        }
    }
}
