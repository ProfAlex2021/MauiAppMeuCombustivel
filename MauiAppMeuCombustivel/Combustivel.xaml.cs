namespace MauiAppMeuCombustivel
{
    public partial class Combustivel : ContentPage
    {
        int count = 0;

        public Combustivel()
        {
            InitializeComponent();
        }

        private void btnCompensa_Clicked(object sender, EventArgs e)
        {
            if (txtEtanol.Text.Equals(string.Empty) || txtGasolina.Text.Equals(string.Empty))
            {
                DisplayAlert("Erro!", "Por favor, preencha os campos", "OK");
                return;
            }

            try
            {
                var etanol = double.Parse(txtEtanol.Text);
                var gasolina = double.Parse(txtGasolina.Text);

                var mensagem = etanol <= gasolina * 0.7 ? "O etanol está compensando." : "A gasolina está compensando.";

                DisplayAlert("Resultado", mensagem, "OK");
            }
            catch (FormatException)
            {
                DisplayAlert("Erro!", "Preencha os campos com apenas números", "OK");
            }
        }

        private async void btnJogo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JogoDaVelha());
        }
    }

}
