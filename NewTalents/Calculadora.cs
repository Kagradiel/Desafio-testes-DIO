using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {

        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            listaHistorico.Insert(0, $"{num1} + {num2} = {res} - Data: {data}");
            return res;
        }
        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listaHistorico.Insert(0, $"{num1} - {num2} = {res} - Data: {data}");
            return res;
        }
        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listaHistorico.Insert(0, $"{num1} * {num2} = {res} - Data: {data}");
            return res;
        }
        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }

            int res = num1 / num2;
            listaHistorico.Insert(0, $"{num1} / {num2} = {res} - Data: {data}");
            return res;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}