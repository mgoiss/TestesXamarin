using System;
using System.Collections.Generic;
using System.Text;

namespace AppIMC.Modelo
{
    public class IMC
    {
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float ValorImc { get; set; }
        public string Resultado { get; set; }

        public IMC(float peso, float altura)
        {
            Peso = peso;
            Altura = altura;
            ValorImc = peso / (Altura * Altura);
            AnalisarResutado();
        }

        public void AnalisarResutado()
        {
            if (ValorImc < 18.5)
            {
                Resultado = "Magreza";
            }
            else if(ValorImc < 24.9)
            {
                Resultado = "Normal";
            }
            else if(ValorImc < 29.9)
            {
                Resultado = "Sobrepeso";
            }
            else if(ValorImc < 39.9)
            {
                Resultado = "Obesidade";
            }
            else
            {
                Resultado = "Obesidade Grave";
            }
        }
    }
}
