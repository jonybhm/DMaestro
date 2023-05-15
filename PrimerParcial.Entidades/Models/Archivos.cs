using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Drawing;



namespace PrimerParcial.Entidades.Models
{
    public class Archivos
    {

        public static void LeerInfoArchivos(List<Reglas> reglas)
        {
            reglas.Add(new Reglas("Estado Paralizado", "Nose puede mover"));
            reglas.Add(new Reglas("Estado Envenenado", "Desventaja"));
            reglas.Add(new Reglas("Estado Agarrado", "Ataque"));
            reglas.Add(new Reglas("Estado Asustado", "Nose puede acercar"));
        }

        public static void LeerInfoUsuarios(List<Usuario> usuario)
        {
            usuario.Add(new Usuario(10000, "jose", "admin", "admin"));
            usuario.Add(new Usuario(10001, "juan", "juan12", "123456"));
            usuario.Add(new Usuario(10002, "micaela", "mica100", "14271824"));
        }

        public static List<object> LeerInfoReglas()
        {
            string rutaArchivoUno = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\06_mechanics-copia.json";

            var tablaUno = Read(rutaArchivoUno);

            return tablaUno;
        }

        public static List<object> LeerInfoItems()
        {
            string rutaArchivoUno = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\items-en.json";

            var tablaUno = Read(rutaArchivoUno);

            return tablaUno;
        }


        public static List<object> LeerInfoEnemigos()
        {
            string rutaArchivo = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\monsters-en.json";

            var tabla = Read(rutaArchivo);

            return tabla;
        }
        public static List<object> LeerInfoHechizos()
        {
            string rutaArchivo = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\spells-en.json";

            var tabla = Read(rutaArchivo);

            return tabla;
        }

        public static List<object> LeerInfoTablaUno()
        {
            string rutaArchivoUno = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\18_tabla1.json";
            
            var tablaUno = Read(rutaArchivoUno);              
                        
            return tablaUno;
           
        }

        public static List<object> LeerInfoTablaDos()
        {
            string rutaArchivoDos = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\19_tabla2.json";

            var tablaDos = Read(rutaArchivoDos);

            return tablaDos;

        }

        public static List<object> LeerInfoTablaTres()
        {
            string rutaArchivoTres = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\20_tabla3.json";

            var tablaTres = Read(rutaArchivoTres);

            return tablaTres;

        }

        public static object ArmarTablaParaDataGrid(List<object> ListaDiccionarios)
        {
            DataTable tabla = new DataTable();

            Dictionary<string, object> dictEnCero = (Dictionary<string, object>)ListaDiccionarios[0];

            foreach (string name in dictEnCero.Keys)
            {
                tabla.Columns.Add(name);
            }

            foreach (Dictionary<string, object> dict in ListaDiccionarios)
            {
                DataRow fila = tabla.NewRow();
                foreach (string name in dictEnCero.Keys)
                {
                    if (dict.ContainsKey(name))
                    {
                        fila[name] = dict[name];
                    }
                    else
                    {
                        fila[name] = "";
                    }

                }

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

        public static Dictionary<string, object> deserializarJsonStringADictionary(string formatoJson)
        {
            Dictionary<string, object> dict = JsonSerializer.Deserialize<Dictionary<string, object>>(formatoJson);
            return dict;
        }

        public static string generarStringDesdeDict(Dictionary<string, object> dict)
        {
            string textoBox = "";
            foreach (KeyValuePair<string, object> item in dict)
            {
                textoBox += " | " + item.Key + ": " + item.Value + " | ";
            }
            return textoBox.ToString();
        }


        public static List<string> deserializarJsonStringAList(string formatoJson)
        {
            List<string> list = JsonSerializer.Deserialize<List<string>>(formatoJson);
            return list;
        }

        public static List<Dictionary<string, object>> deserializarJsonStringAListDos(string formatoJson)
        {
            List<Dictionary<string, object>> list = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(formatoJson);
            return list;
        }


        public static string generarStringDesdeList(List<string> list)
        {
            string textoBox = "";
            foreach (var item in list)
            {
                textoBox += " | " + item + " | ";
            }
            return textoBox.ToString();
        }
        public static string generarStringDesdeListDos(string formatoDict)
        {
            string textoFinal = "";
            List<Dictionary<string, object>> lista = deserializarJsonStringAListDos(formatoDict);
            foreach (Dictionary<string, object> item in lista)
            {
                foreach (KeyValuePair<string, object> par in item)
                {
                    textoFinal += par.Value + "\n";
                }
                textoFinal += "\n";
            }
            return textoFinal.ToString();
        }

        /*public static string ConcatenarStringsParaTextBox(List<object> ListaDiccionarios)
        {
            string textoFinal = "";
            //Font fuenteTitulo = new Font("Universal Serif", 15, FontStyle.Bold);
            //Font fuenteSubTitulo = new Font("Universal Serif", 12);
            //Font fuenteContenido = new Font("Arial", 10);
            string fuenteTitulo = $"{"Arial"},{20}";
            
            foreach (Dictionary<string, object> dict in ListaDiccionarios)
            {
                foreach(string key in dict.Keys)
                {
                    switch(key)
                    {
                        case "titulo":
                            textoFinal += $"{{\\rtf1\\ansi\\deff0{{\\fonttbl{{\\f0 {fuenteTitulo};}}}}\\f0 {dict[key]}}}"+ Environment.NewLine;                            
                            //textoFinal += dict[key] + Environment.NewLine;
                            break;
                        case "subtitulo":
                            textoFinal += $"{{\\rtf1\\ansi\\deff0{{\\fonttbl{{\\f0 {fuenteTitulo};}}}}\\f0 {dict[key]}}}" + Environment.NewLine;
                            //textoFinal += dict[key] + Environment.NewLine;
                            break;
                        case "contenido":
                            textoFinal += $"{{\\rtf1\\ansi\\deff0{{\\fonttbl{{\\f0 {fuenteTitulo};}}}}\\f0 {dict[key]}}}" + Environment.NewLine;
                            //textoFinal += dict[key] + Environment.NewLine;
                            break;
                    }                   
                }
            }

            return textoFinal;
        }*/


        public static List<object> Read(string ruta)
        {            
            var lista = new List<object>();
            var rta = File.ReadAllText(ruta);
            var jsonarray = JsonArray.Parse(rta);
            foreach (var item in jsonarray!.AsArray())
                {
                Dictionary<string, object> dict = JsonSerializer.Deserialize<Dictionary<string, object>>(item);
                lista.Add(dict);
                    
                }                     
            return lista;

        }

        
    }
}
