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
        protected string nombreBebida;
        protected string tamanio;
        protected float precio;

        //propiedades
        public string _nombreBebida {
            get {return nombreBebida;}
            set { nombreBebida = value; }
        }

        public string _tamanio {
            get { return tamanio; }
            set { tamanio = value; }
        }

        public float _precio {
            get { return precio; }
            set { if (value>0) 
                    precio = value;
                }
        }

        //constructor vacio
        public Bebida() {
            nombreBebida = "";
            tamanio = "";
            precio = 0;
        }

        //constructor parametrizado
        public Bebida(string nombreBebida, string tamanio, float precio) {
            this.nombreBebida = nombreBebida;
            this.tamanio = tamanio;
            this.precio = precio;
        }

        //metodos
        public virtual string preparar() {
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
