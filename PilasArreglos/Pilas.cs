using System;
using System.Collections.Generic;
using System.Text;

namespace PilasArreglos
{
    internal class Pilas
    {
        string[] _pila;
        int _tope;

        public Pilas(int elementos)
        {
            _pila = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato)
        {
            if (_tope == _pila.Length) 
            {
                throw new Exception("La pila esta llena"); 
            }
            _pila[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("La pila esta vacia");
            }
            _tope--;
            _pila[_tope] = string.Empty;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            for (int i = _tope - 1; i >= 0; i--)
            {
                datos.AppendLine(_pila[i]);
            }
            return datos.ToString();

        }
    }
}
