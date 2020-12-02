using System;
using EstructurasG4;
using System.Collections.Generic;

namespace EjemploEstructurasDatosG4
{
    class Program
    {
        
        static void Main()
        {
            Empleado empleado;
            empleado.nombre = "Armando";
            empleado.edad = 50;
            empleado.antiguedad = 15;
            empleado.direccion.calle = "Las américas";
            empleado.direccion.codigoPostal = "099000";

            //         Console.WriteLine("Mostrando datos del empleado");
            //         Console.WriteLine("Nombre: {0} \n Edad: {1} \n Antigüedad: {2}  ", empleado.nombre, empleado.edad, empleado.antiguedad);
            //          Console.ReadLine();

            /*            Empleado empleado1=empleado;
                        Console.WriteLine("Ingresa los datos del empleado ");
                        Console.WriteLine("Ingresa el nombre: ");
                        empleado1.nombre = Console.ReadLine();
                       Console.WriteLine("Ingresa la edad:");
                        empleado1.edad = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la antigüedad: ");
                        empleado1.antiguedad = byte.Parse(Console.ReadLine());


                        Console.WriteLine("Mostrando datos del empleado");
                        Console.WriteLine("Nombre: {0} \n Edad: {1} \n Antigüedad: {2}  ", empleado1.nombre, empleado1.edad, empleado1.antiguedad);
                        Console.ReadLine();
            */
            /*
                        Empleado[] empleados = new Empleado[2];

                        for(int i =0; i < empleados.Length; i++)
                        {                
                            Console.WriteLine("Ingresa los datos del empleado ");
                            Console.WriteLine("Ingresa el nombre: ");
                            empleados[i].nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa la edad:");
                            empleados[i].edad = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la antigüedad: ");
                            empleados[i].antiguedad = byte.Parse(Console.ReadLine());
                        }
            */
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(empleado);
            for (int i = 0; i < 1; i++)
            {

                Console.WriteLine("Ingresa los datos del empleado ");
                Console.WriteLine("Ingresa el nombre: ");
                empleado.nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad:");
                empleado.edad = byte.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la antigüedad: ");
                empleado.antiguedad = byte.Parse(Console.ReadLine());
                empleados.Add(empleado);
            }

            Console.WriteLine("Nombre:{0} ", empleados[0].nombre);

            Console.ReadLine();



/*
            Console.WriteLine("Mostrando datos del empleado");
            Console.WriteLine("Nombre: {0} \n Edad: {1} \n Antigüedad: {2}  ", empleado.nombre, empleado.edad, empleado.antiguedad);
            Console.ReadLine();
*/

        }
    }
}
