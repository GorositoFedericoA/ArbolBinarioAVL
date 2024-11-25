namespace WindowsFormsApp1.Carpeta
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public Nodo Derecha { get; set; }
        public Nodo Izquierda { get; set; }

        public Nodo(string nombre, Nodo derecha = null, Nodo izquierda = null )
        {
            Nombre = nombre;
            Derecha = derecha;
            Izquierda = izquierda;
        }

    }
}
