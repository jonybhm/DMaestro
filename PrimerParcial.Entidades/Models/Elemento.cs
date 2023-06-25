using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Drawing;
using PrimerParcial.Entidades.SQL;
using System.Reflection;


namespace PrimerParcial.Entidades.Models
{
    public abstract class Elemento
    {
        
        public int id
        {
           get; set;
        }
        
        public string name
        {
            get; set;
        }
        /// <summary>
        /// Inicializa una nueva instania de la clase Elemento.
        /// </summary>
        /// <param name="id">identificador numerico.</param>
        /// <param name="name">nombre del elemento.</param>
        public Elemento(int id, string name) 
        { 

        }

        
      
       /// <summary>
       /// Inicializa un DataTable con la informacion de una lista de diccionarios, donde cada columna representa una key.
       /// </summary>
       /// <param name="ListaDiccionarios">Lista de diccionarios con datos para la tabla.</param>
       /// <returns>La tabla con datos en las celdas y encabezado de columnas.</returns>
        public static object ArmarTablaParaDataGrid(List<Dictionary<string,object>> ListaDiccionarios)
        {
            DataTable tabla = new DataTable();

            Dictionary<string, object> dictEnCero = (Dictionary<string, object>)ListaDiccionarios[0];

            bool esCeldaVacia;

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
                        esCeldaVacia = false;
                    }
                    else
                    {
                        esCeldaVacia = true;

                    }
                    switch(esCeldaVacia)
                    {
                        case false:
                            fila[name] = dict[name];
                            break;
                        
                        case true:
                            fila[name] = "";
                            break;
                    }

                }

                tabla.Rows.Add(fila);
            }

            return tabla;
        }

       
        

        public abstract void AgregarInfo(Dictionary<string, object> dictDatosFilas);

        /// <summary>
        /// Carga valores en un diccionario en base a los valores de un objeto.
        /// </summary>
        public static Dictionary<string, object> CrearDictConDatos(Elemento datosElemento)
        {

            Dictionary<string, object> dictDatosElemento = new Dictionary<string, object>();

            PropertyInfo[] propiedades = datosElemento.GetType().GetProperties();
            bool flagPrimerVuelta = false;
            foreach (PropertyInfo prop in propiedades)
            {
                if (flagPrimerVuelta)
                {
                    flagPrimerVuelta = false;
                    continue;
                }
                string nombrePropiedad = prop.Name;
                object valorPropiedad = prop.GetValue(datosElemento);
                dictDatosElemento.Add(nombrePropiedad, valorPropiedad);
            }

            return dictDatosElemento;
        }

    }
}
