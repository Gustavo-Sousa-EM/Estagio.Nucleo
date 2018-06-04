using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo
{
    public class CPFCNPJ
    {
        public CPFCNPJ(string Numero)
        {
            Numero = Numero.Trim();
            Numero = Numero.Replace(".", "").Replace("-", "");
            var resto = 0;
            var soma = 0;
            if (Numero.Length == 11)
            {
                var calcularPeso1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                var calcularPeso2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                var cpfD = new int[11];
                {
                    var validador = false;
                    while (validador == false)
                    {
                        var contador = 0;
                        var iContador = 0;
                        while (iContador != 11)
                        {
                            foreach (var item2 in Numero)
                            {
                                var Intitem2 = Convert.ToInt32(item2.ToString());
                                if (Intitem2 == iContador)
                                {
                                    contador++;
                                }
                            }
                            if (contador == 11)
                            {
                                validador = false;
                            }
                            else
                            {
                                iContador++;
                                contador = 0;
                                validador = true;
                            }
                        }
                        validador = true; ;
                    }
                    if (validador)
                    {
                        var iContador = 0;
                        for (var jContador = 0; jContador < cpfD.Length; jContador++)
                        {
                            cpfD[iContador++] = int.Parse(Numero[jContador].ToString());
                        }

                        for (var jContador = 0; jContador < calcularPeso1.Length; jContador++)
                        {
                            soma += cpfD[jContador] * calcularPeso1[jContador];
                        }
                        resto = soma % 11;
                        if (resto < 2)
                        {
                            resto = 0;
                        }
                        else
                        {
                            resto = 11 - resto;
                        }
                        if (resto == cpfD[9])
                        {
                            soma = 0;
                            for (var jContador = 0; jContador < calcularPeso2.Length; jContador++)
                            {
                                soma += cpfD[jContador] * calcularPeso2[jContador];
                            }
                            resto = soma % 11;
                            if (resto < 2)
                            {
                                resto = 0;
                            }
                            else
                            {
                                resto = 11 - resto;
                            }
                            if (resto == cpfD[10])
                            {
                                Console.WriteLine("CPF Válido!");
                                var cpfFormatado = Convert.ToUInt64(Numero).ToString(@"000\.000\.000\-00");
                                Console.WriteLine("CPF: " + cpfFormatado);
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
            else if (Numero.Length == 14)
            {
                var peso1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                var peso2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                var CNPJD = new int[14];

                for (var IContador = 0; IContador < CNPJD.Length; IContador++)
                {
                    CNPJD[IContador] = int.Parse(Numero[IContador].ToString());
                }
                for (var IContador = 0; IContador < peso1.Length; IContador++)
                {
                    soma += CNPJD[IContador] * peso1[IContador];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                if (resto == CNPJD[12])
                {
                    for (var IContador = 0; IContador < peso2.Length; IContador++)
                    {
                        soma += CNPJD[IContador] * peso2[IContador];
                    }
                    resto = soma % 11;
                    if (resto < 2)
                    {
                        resto = 0;
                    }
                    else
                    {
                        resto = 11 - resto;
                    }
                    if (resto == CNPJD[13])
                    {
                        Console.WriteLine("CNPJ Válido!");
                        var cpfFormatado = Convert.ToUInt64(Numero).ToString(@"00\.000\.000\/0000\-00");
                        Console.WriteLine("CNPJ " + cpfFormatado);
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }

}
}
}

