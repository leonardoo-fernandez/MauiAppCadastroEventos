using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class CadastrarEvento : ContentPage
{
	public CadastrarEvento()
	{
		InitializeComponent();

		dtpck_inicio.MinimumDate = DateTime.Now;
		
		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento evento = new Evento
			{
				NomeEvento = txt_nomeEvento.Text,

				DataInicio = dtpck_inicio.Date,

				DataTermino = dtpck_termino.Date,

				NumParticipantes = Convert.ToInt32(txt_NumParticipantes.Text),

				LocalEvento = txt_nomeEvento.Text,

				CustoParticipante = Convert.ToDouble(txt_custoParticipante.Text),
			};

			await Navigation.PushAsync(new ResumoEvento()
			{
				BindingContext = evento,
			});

		}catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
	
	private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

        dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
	}
}