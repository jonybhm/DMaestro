using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

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
        public static List<object> LeerInfoEnemigos()
        {
            /*enemigo.Add(new Enemigo("goblin", 50, 1 / 4));
            enemigo.Add(new Enemigo("dragon rojo", 5900, 10));
            enemigo.Add(new Enemigo("quimera", 2300, 6));*/

            string rutaArchivo = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\17_bestiary.json";

            var tabla = Read(rutaArchivo);

            return tabla;
        }

        public static List<object> LeerInfoTablaUno()
        {
            string rutaArchivo = @"C:\Users\JONY\Desktop\Programación\2 do Cuatri\Programacion 2\Proyectos\DeCastro_PrimerParcial\Json\18_tabla1.json";
            
            var tabla = Read(rutaArchivo);              
                        
            return tabla;
           
        }

        public static object ArmarTablaParaDataGrid(List<object> ListaDiccionarios)
        {
            //dataGridTablaReferencia.DataSource = null;

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
            //dataGridTablaReferencia.DataSource = tabla;
        }


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
