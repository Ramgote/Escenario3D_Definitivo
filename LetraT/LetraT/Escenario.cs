using System;
using OpenTK;
using System.Collections.Generic;

namespace LetraT
{
    public class Escenario : IDibujable
    {
        public Dictionary<String, Objeto> listaDeObjetos;
        protected Punto centro;

        public Escenario(Punto centro)
        {
            this.listaDeObjetos = new Dictionary<String, Objeto>();
            this.centro = centro;
        }

        public void addObjeto(String nombre, Objeto nuevoObjeto)
        {
            this.listaDeObjetos.Add(nombre, nuevoObjeto);
        }

        public void deleteObjeto(String objetoAEliminar)
        {
            this.listaDeObjetos.Remove(objetoAEliminar);
        }

        public Objeto getObjeto(String nombre)
        {
            return this.listaDeObjetos[nombre];
        }

        public void setObjeto(String nombre, Objeto objeto)
        {
            this.listaDeObjetos[nombre] = objeto;
        }

        public void Dibujar(Punto centro)
        {
            foreach (Objeto objetoActual in this.listaDeObjetos.Values)
            {
                objetoActual.Dibujar(centro);
            }
        }
    }
}
