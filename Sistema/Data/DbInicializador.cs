using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class DbInicializador
    {
        public static void Inicializar(SistemaContext context)
        {
            context.Database.EnsureCreated();
            //Buscar si existen registros en la tabla categoría
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacíon",Descripcion="Cursos de programación",Estado=true},
                new Categoria{Nombre="Ingles",Descripcion="Cursos de Ingles",Estado=true}
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
