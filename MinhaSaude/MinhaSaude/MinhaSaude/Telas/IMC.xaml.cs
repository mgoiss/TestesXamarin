using System;
using MinhaSaude.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinhaSaude.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IMC : ContentPage
	{
		public IMC ()
		{
			InitializeComponent ();
		}

        private void Calculo(object sender, EventArgs args)
        {
            if (isValidDados())
            {
                try
                {
                    ClasseIMC imc = new ClasseIMC(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));


                    lblResultado.Text = string.Format("Seu IMC é: {0:F2}\n\n" +
                                                       "Avaliação: {1}", imc.ValorImc, imc.Resultado.ToUpper());
                }
                catch (Exception ex)
                {
                    DisplayAlert("ERRO", ex.Message, "OK");
                }
            }
        }

        private bool isValidDados()
        {
            bool valido = true;
            float novoValor = 0;

            if (txtPeso.Text == null || txtAltura.Text == null)
            {
                DisplayAlert("ERRO", "Preencha todos os campos.", "OK");

                valido = false;
            }
            else if (!float.TryParse(txtPeso.Text, out novoValor) || !float.TryParse(txtAltura.Text, out novoValor))
            {
                DisplayAlert("ERRO", "Preencha os campos apenas com numeros.", "OK");

                valido = false;
            }

            return valido;
        }
    }
}