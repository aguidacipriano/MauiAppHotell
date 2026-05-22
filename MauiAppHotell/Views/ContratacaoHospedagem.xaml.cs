namespace MauiAppHotell.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource =
                PropriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate =
                DateTime.Now;

            dtpck_checkout.MinimumDate =
                DateTime.Now.AddDays(1);

            dtpck_checkout.MaximumDate =
                DateTime.Now.AddMonths(6);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(
                    new HospedagemContratada()
                );
            }
            catch (Exception ex)
            {
                await DisplayAlert(
                    "Ops",
                    ex.Message,
                    "OK"
                );
            }
        }

        private void dtpck_checkin_DateSelected(
            object sender,
            DateChangedEventArgs e)
        {
            DateTime data_selecionada_checkin =
                e.NewDate ?? DateTime.Now;

            dtpck_checkout.MinimumDate =
                data_selecionada_checkin.AddDays(1);

            dtpck_checkout.MaximumDate =
                data_selecionada_checkin.AddMonths(6);
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack.Count > 1)
            {
                await Navigation.PopAsync();
            }
        }
    }
}