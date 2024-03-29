﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Archivos
    {
        
        //Metodos para generar strings desde listas y diccionarios para mostrar en tarjetas

        /// <summary>
        /// Genera un string con un formato determinado para mostrar en pantalla.
        /// </summary>
        /// <param name="dict">Diccionaro con datos a mostrar.</param>
        /// <returns>String que se mostrará en pantalla.</returns>
        public static string generarStringDesdeDict(Dictionary<string, object> dict)
        {
            string textoBox = "";
            foreach (KeyValuePair<string, object> item in dict)
            {
                textoBox += item.Key + ":" + item.Value + "|";
            }
            return textoBox.ToString();
        }


        /// <summary>
        /// Genera un string con un formato determinado para mostrar en pantalla.
        /// </summary>
        /// <param name="dict">Lista con datos a mostrar.</param>
        /// <returns>String que se mostrará en pantalla.</returns>
        public static string generarStringDesdeList(List<string> list)
        {
            string textoBox = "";
            foreach (var item in list)
            {
                textoBox += item + "|";
            }
            return textoBox.ToString();
        }

        /// <summary>
        /// Genera un string con un formato determinado para mostrar en pantalla.
        /// </summary>
        /// <param name="dict">Lista de Diccionaros con datos a mostrar.</param>
        /// <returns>String que se mostrará en pantalla.</returns>
        public static string generarStringDesdeListDict(List<Dictionary<string, object>> formatoDict)
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

        /// <summary>
        /// Genera una Lista desde un string para guardar info en json.
        /// </summary>
        /// <param name="textBox">string con info en Text Box</param>
        /// <returns>Lista para guardar info en json.</returns>
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

        /// <summary>
        /// Genera un Diccionario desde un string para guardar info en json.
        /// </summary>
        /// <param name="textBox">string con info en Text Box</param>
        /// <returns>Diccionario para guardar info en json.</returns>
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

        /// <summary>
        /// Genera una Lista de Diccionarios desde un string para guardar info en json.
        /// </summary>
        /// <param name="textBox">string con info en Text Box</param>
        /// <returns>Lista de Diccionarios para guardar info en json.</returns>
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

                    dict["name"] = nameText[0];
                    dict["text"] = nameText[1];

                }

                list.Add(dict);
            }


            return list;
        }

        //Metodos para leer y escribir archivos json



        /// <summary>
        /// Leer info de archivo Json en formato de Array para procesar informacion en tablas.
        /// </summary>
        /// <param name="nombreArchivo">string con el nombre del archivo sin extension.</param>
        /// <returns>Lista de Diccionarios con los datos del Json.</returns>
        public static List<Dictionary<string, object>> LeerInfoArchivo(string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";

            var lista = new List<Dictionary<string, object>>();
            var rta = File.ReadAllText(ruta);
            var jsonarray = JsonArray.Parse(rta);
            foreach (var item in jsonarray!.AsArray())
            {
                Dictionary<string, object> dict = JsonSerializer.Deserialize<Dictionary<string, object>>(item);
                lista.Add(dict);

            }
            return lista;

        }



        /// <summary>
        /// Leer y parsear info de archivo Json en formato JsonElement.
        /// </summary>
        /// <param name="nombreArchivo">string con el nombre del archivo sin extension.</param>
        /// <returns>JsonElemnt con los datos del Json.</returns>
        public static JsonElement LeerInfoDocumento(string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";

            var rta = File.ReadAllText(ruta);
            var jsonarray = JsonDocument.Parse(rta).RootElement;
            return jsonarray;
        }

        /// <summary>
        /// Agrega nueva entrada en el Json al final del mismo.
        /// </summary>
        /// <param name="elemento">Objeto a agregar al Json.</param>
        /// <param name="nombreArchivo">string con el nombre del archivo Json.</param>
        public static void AgregarInfoEnArchivo(Dictionary<string, object> elemento, string nombreArchivo)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";
            var jsonExistente = LeerInfoArchivo(nombreArchivo);
            jsonExistente.Add(elemento);

            string contenidoNuevo = JsonSerializer.Serialize(jsonExistente, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, contenidoNuevo);

        }

        /// <summary>
        /// Modifica entrada en el Json dada una id del mismo.
        /// </summary>
        /// <param name="elemento">Objeto a agregar al Json.</param>
        /// <param name="nombreArchivo">string con el nombre del archivo Json.</param>
        /// <param name="id">int con la posicion de la entrada en el Json.</param>
        public static void ModificarInfoEnArchivo(Dictionary<string, object> elemento, string nombreArchivo, int id)
        {
            string ruta = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\{nombreArchivo}.json";
            var jsonExistente = LeerInfoArchivo(nombreArchivo);
            int posicionJson = id;
            jsonExistente[posicionJson] = elemento;


            string contenidoNuevo = JsonSerializer.Serialize(jsonExistente, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, contenidoNuevo);

        }
        /// <summary>
        /// Exporta un string en formato .txt
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="texto"></param>
        public static void CrearArchivoTXT(string nombreArchivo, string texto)
        {
            using (var writer = new StreamWriter(nombreArchivo, true))
                {
                    writer.WriteLine(texto);
                }
        }

        /// <summary>
        /// Exportar info de lista de diccionarios a archivo json.
        /// </summary>
        /// <param name="listaDiccionarios"></param>
        /// <param name="nombreArchivo"></param>
        public static void ExportarAJSON(List<Dictionary<string, object>> listaDiccionarios, string nombreArchivo)
        {
            string path = $@"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json_Exportados\{nombreArchivo}.json";
            string jsonData = JsonSerializer.Serialize(listaDiccionarios, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(path, jsonData);
        }

    }
}
