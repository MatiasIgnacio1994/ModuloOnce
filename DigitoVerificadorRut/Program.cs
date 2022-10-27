using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitoVerificadorRut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutSDV = "";
            List<int> digitos = new List<int>();
            int suma = 0, peso = 2, moduloOnce = 0, restar = 0, diferencia = 0, resultado = 0;
            Console.Write("Ingrese su RUT sin dígito verificador: ");
            rutSDV = Console.ReadLine();

            foreach (char n in rutSDV)
            {
                digitos.Add((int)Char.GetNumericValue(n));
            }

            digitos.Reverse();

            for(int i = 0; i < digitos.Count; i++)
            {
                if(peso > 7)
                {
                    peso = 2;
                    suma = suma + digitos[i] * peso;
                    peso++;
                }
                else
                {
                    suma = suma + digitos[i] * peso;
                    peso++;
                }
            }
            moduloOnce = suma / 11;
            restar = moduloOnce * 11;
            diferencia = suma - restar;
            resultado = 11 - diferencia;

            if(resultado != 10)
            {
                Console.Write("El Rut completo es: " + rutSDV + "-" + resultado.ToString());
            }
            else
            {
                Console.Write("El Rut completo es: " + rutSDV + "-K");
            }
            Console.ReadKey();
        }
    }
}
