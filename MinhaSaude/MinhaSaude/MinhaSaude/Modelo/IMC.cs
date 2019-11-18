using System;
using System.Collections.Generic;
using System.Text;

namespace MinhaSaude.Modelo
{
    public class ClasseIMC
    {
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float ValorImc { get; set; }
        public string Resultado { get; set; }
        public string CorResultado { get; set; }

        public ClasseIMC(float peso, float altura)
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
                Resultado = "Abaixo do Peso";
                CorResultado = "#ffde00";
            }
            else if (ValorImc < 25)
            {
                Resultado = "Peso Normal";
                CorResultado = "#2891ce";
            }
            else if (ValorImc < 30)
            {
                Resultado = "Acima do Peso";
                CorResultado = "#ff6c00";
            }
            else
            {
                Resultado = "Obeso";
                CorResultado = "#e60000";
            }
        }
    }
}
