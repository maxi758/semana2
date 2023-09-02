namespace primeraSolucion
{
    internal class Persona
    {
        public Persona(string nombre, string apellido, string documento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
        }

        public string Nombre { get; }
        public string Apellido { get; }
        public string Documento { get; }
        // generate a string with the data
        public override string ToString()
        {
            return $"{Nombre} {Apellido} {Documento}";
        }
    }
}