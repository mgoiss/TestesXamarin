using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MinhaSaude.Telas;
using MinhaSaude.Modelo;

namespace MinhaSaude
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new ModeloVisual();
        }

        private void Comecar(object sender, EventArgs e)
        {
            App.Current.MainPage = new Abas();
        }
    }
}
