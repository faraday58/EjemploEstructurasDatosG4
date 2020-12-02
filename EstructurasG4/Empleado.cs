
namespace EstructurasG4
{
    public struct Empleado
    {
        public string nombre;
        public byte edad;
        public byte antiguedad;
        public Direccion direccion;
        
        public Empleado(string nombre, byte edad, byte antiguedad, Direccion direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.antiguedad = antiguedad;
            this.direccion = direccion;
        }

    }

    public struct Direccion
    {
        public string calle;
        public string codigoPostal;
    }
}
