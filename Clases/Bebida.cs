using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace PryCafeteria.Clases
{
    internal class Bebida
    {
        //atributos de mi clase
        private string nombreBebida;
        private string tamanio;
        private float precio;

        //constructor de la clase bebida
        public Bebida(string nombreBebida, string tamanio, float precio) {
            this.nombreBebida = nombreBebida;
            this.tamanio = tamanio;
            this.precio = precio;
        }
        //comienzo de los metodos
        public string preparar() {
            return $"Su {nombreBebida} de tamaño {tamanio} se esta preparando...";
        }

        public void aplicarDescuento(float porcentaje) {
            float descuento = porcentaje * precio / 100;
            precio = precio - descuento;
        }

        public string mostrarDescripcion() {
            return $"Esto es un {nombreBebida} de tamaño {tamanio} con un costo de $ {precio}";
        }
    }
}
