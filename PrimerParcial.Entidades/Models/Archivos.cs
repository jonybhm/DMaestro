using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades.Models
{
    public class Archivos
    {
        public static void LeerInfoArchivos(List<Reglas> reglas)
        {
            reglas.Add(new Reglas("Estado Paralizado","Nose puede mover"));
            reglas.Add(new Reglas("Estado Envenenado", "Desventaja"));
            reglas.Add(new Reglas("Estado Agarrado", "Ataque"));
            reglas.Add(new Reglas("Estado Asustado", "Nose puede acercar"));
        }

        public static void LeerInfoUsuarios(List<Usuario> usuario)
        {
            usuario.Add(new Usuario(10000,"jose","admin", "admin"));
            usuario.Add(new Usuario(10001, "juan", "juan12", "123456"));
            usuario.Add(new Usuario(10002, "micaela", "mica100", "14271824"));
        }
    }


}
