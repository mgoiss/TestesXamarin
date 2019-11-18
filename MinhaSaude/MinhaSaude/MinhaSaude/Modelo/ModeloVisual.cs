using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MinhaSaude.Modelo
{
    public class ModeloVisual : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        public ObservableCollection<ItensCarrossel> Itens { get; }

        private int _position;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        public ModeloVisual()
        {
            Itens = new ObservableCollection<ItensCarrossel>();

            ItensCarrossel item = new ItensCarrossel
            {
                Titulo = "Bem vindo",
                Detalhe = "Aqui temos algumas funções para cuidar da sua saúde",
                Imagem = "TelaInicial1.png"
            };

            Itens.Add(item);

            item = new ItensCarrossel
            {
                Titulo = "Sua saúde é importante",
                Detalhe = "Calcule seu IMC e a qauntidade de Água que deve beber",
                Imagem = "TelaInicial2.png"
            };

            Itens.Add(item);


        }
    }
}
