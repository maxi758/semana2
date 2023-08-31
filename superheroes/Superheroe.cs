using System;
using System.Collections.Generic;
using System.Text;

namespace superheroes
{
    internal class Superheroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public Superheroe(string nombre, int fuerza, int superpoderes, int resistencia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Superpoderes = superpoderes;
            Resistencia = resistencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Fuerza
        {
            get => fuerza;
            private set
            {
                fuerza = ValidarNumero(value);
            }
        }

        public int Superpoderes
        {
            get => superpoderes;
            private set
            {
                superpoderes = ValidarNumero(value);
            }
        }
        public int Resistencia
        {
            get => resistencia;
            private set 
            { 
                resistencia = ValidarNumero(value); 
            }
        }
        private int ValidarNumero(int value)
        {//se pueden poner las validaciones en otro orden
            if (value >= 0 && value <= 100)
                return value;
            else if (value < 0)
                return 0;
            else
                return 100;
        }
        public string Ganador(Superheroe otro)
        {
            int puntos = 0;
            if (Fuerza > otro.Fuerza)
                puntos++;
            else if (Fuerza < otro.Fuerza)
                puntos--;
            if (Superpoderes > otro.Superpoderes)
                puntos++;
            else if (Superpoderes < otro.Superpoderes)
                puntos--;
            if (Resistencia > otro.Resistencia)
                puntos++;
            else if (Resistencia < otro.Resistencia)
                puntos--;
            if (puntos > 0)
                return $"{Nombre} es el ganador";
            else if (puntos < 0)
                return $"{otro.Nombre} es el ganador";
            else
                return "Empate";
        }


        public override string ToString()
        {

            return $"Nombre: {Nombre} Fuerza: {Fuerza} Superpoderes: {Superpoderes} Resistencia: {Resistencia}";
        }

    }
}
