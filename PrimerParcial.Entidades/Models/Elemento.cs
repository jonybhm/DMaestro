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
    public class Elemento
    {
        
        public int id
        {
           get; set;
        }
        
        public string name
        {
            get; set;
        }

        public Elemento(int id, string name) 
        { 

        }

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

        //ELIMINAR METODOS DE SERIALIZACION!!!
        public static Dictionary<string, object> deserializarJsonStringADictionary(string formatoJson)
        {
            Dictionary<string, object> dict = JsonSerializer.Deserialize<Dictionary<string, object>>(formatoJson);
            return dict;
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

        //Metodos para generar strings desde listas y diccionarios para mostrar en tarjetas

        public static string generarStringDesdeDict(Dictionary<string, object> dict)
        {
            string textoBox = "";
            foreach (KeyValuePair<string, object> item in dict)
            {
                textoBox += item.Key + ":" + item.Value + "|"; 
            }
            return textoBox.ToString();
        }

        
        public static string generarStringDesdeList(List<string> list)
        {
            string textoBox = "";
            foreach (var item in list)
            {
                textoBox += item + "|";
            }
            return textoBox.ToString();
        }
        public static string generarStringDesdeListDict(List<Dictionary<string,object>> formatoDict)
        {
            string textoFinal = "";
            foreach (Dictionary<string, object> item in formatoDict)
            {
                foreach (KeyValuePair<string, object> par in item)
                {
                    textoFinal += par.Value + "/" + "\n";
                }
                textoFinal += "-" + "\n";
            }
            return textoFinal.ToString();
        }

        //Metodos para generar listas y diccionarios desde strings para guardar en jsons
        public static List<string> generarListDesdeString(string textBox)
        {

            List<string> list = new List<string>();

            string[] itemsList = textBox.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in itemsList)
            {
                list.Add(item);
            }

            return list;
        }

        public static Dictionary<string, object> generarDictDesdeString(string textBox)
        {

            Dictionary<string, object> dict = new Dictionary<string, object>();

            string[] parKeyValue = textBox.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string par in parKeyValue)
            {
                if (par.Contains(":"))
                {
                    string[] keyValue = par.Split(':');

                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        int value = int.Parse(keyValue[1].Trim());
                        dict[key] = value;
                    }
                }

            }

            return dict;
        }

        public static List<Dictionary<string, object>> generarListDeDictDesdeString(string textBox)
        {

            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();            


            string[] parNameText = textBox.Split(new[] { '-' });

            foreach (string par in parNameText)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();

                if (par.Contains("/"))
                {
                    string[] nameText = par.Split('/');

                    dict["name"]  = nameText[0];
                    dict["text"] = nameText[1];
                    
                }

                list.Add(dict);
            }
                        

            return list;
        }

        //Metodos para leer y escribir archivos json

        public static List<object> LeerInfoArchivo(string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";

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

        public static void AgregarInfoEnArchivo(object elemento, string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";
            var jsonExistente = LeerInfoArchivo(nombreArchivo);
            jsonExistente.Add(elemento);

            string contenidoNuevo = JsonSerializer.Serialize(jsonExistente, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(ruta,contenidoNuevo);         

        }

        public static void ModificarInfoEnArchivo(Elemento elemento, string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";
            var jsonExistente = LeerInfoArchivo(nombreArchivo);
            int posicionJson = elemento.id;
            jsonExistente[posicionJson] = elemento;


            string contenidoNuevo = JsonSerializer.Serialize(jsonExistente, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, contenidoNuevo);

        }

    }
}
