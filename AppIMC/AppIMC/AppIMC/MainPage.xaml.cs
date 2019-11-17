using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppIMC.Modelo;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnCalcular.Clicked += Calculo;
        }

        private void Calculo(object sender, EventArgs args)
        {
            if (isValidDados())
            {
                try
                {
                    IMC imc = new IMC(float.Parse(txtPeso.Text), float.Parse(txtAltura.Text));

                    lblResultado.Text = string.Format("Seu IMC é: {0}\n\n" +
                                                       "Avaliação: {1}", imc.ValorImc, imc.Resultado);
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
