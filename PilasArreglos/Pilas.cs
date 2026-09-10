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
    }
}
