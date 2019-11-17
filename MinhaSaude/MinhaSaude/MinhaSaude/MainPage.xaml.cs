using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MinhaSaude.Telas;

namespace MinhaSaude
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Comecar(object sender, EventArgs e)
        {
            App.Current.MainPage = new Abas();
        }
    }
}
