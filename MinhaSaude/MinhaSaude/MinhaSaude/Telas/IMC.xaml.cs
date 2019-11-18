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
            txtIMC.IsVisible = false;
            txtDescricao.IsVisible = false;
            lblTitulo.IsVisible = false;
            lblDescricao.IsVisible = false;
            ImagemIMC.IsVisible = false;

            txtIMC.Text = string.Format("");
            txtDescricao.Text = string.Format("");


            if (isValidDados())
            {
                try
                {
                    ClasseIMC imc = new ClasseIMC(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));

                    txtIMC.TextColor = Color.FromHex(imc.CorResultado);
                    txtDescricao.TextColor = Color.FromHex(imc.CorResultado);                    

                    txtIMC.IsVisible = true;
                    txtDescricao.IsVisible = true;
                    lblTitulo.IsVisible = true;
                    lblDescricao.IsVisible = true;
                    ImagemIMC.IsVisible = true;

                    txtIMC.Text = string.Format("{0:F2}", imc.ValorImc);
                    txtDescricao.Text = string.Format("{0}", imc.Resultado.ToUpper());
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