using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSennova
{
    class Proyecto
    {
        #region Atributos
        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion
        #region Constructores
        //constr + tab + tab
        public Proyecto(string nombre, int codigo, string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        #endregion
        #region metodos
        public void IngresaProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo");
            Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el area del proyecto");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del proyecto");
            Duracion = int.Parse(Console.ReadLine());
        }
        public void Imprimiproyecto()
        {
            Console.WriteLine($"El nombre del proyecto es:{Nombre}");
            Console.WriteLine($"El codigo del proyecto es:{Codigo}");
            Console.WriteLine($"El area del proyecto es:{Area}");
            Console.WriteLine($"La duracion del proyecto es:{Duracion}");

            Console.ReadLine();
        }
        #endregion


    }
}
