using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    internal class CalculadoraChallengeRating
    {
        public double Cuenta(string cajaNumeros)
        {
            Random random = new Random();
            double resultado = 0;

            foreach (var c in cajaNumeros.Split('+').ToList())
            {
                if (c.Contains('d'))
                {
                    try
                    {

                        resultado += random.Next(1, Convert.ToInt32(c.Remove(0, 1)) + 1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }


                }
                else
                {
                    if (c.Contains("-"))
                    {
                        var moduloResta = c.Split('-').ToList();
                        resultado += Convert.ToDouble(moduloResta[0]);
                        foreach (var d in moduloResta.Skip(1))
                        {
                            try
                            {
                                resultado -= Convert.ToDouble(d);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            resultado += Convert.ToDouble(c);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }
            }
            return resultado;
        }
    }
}
