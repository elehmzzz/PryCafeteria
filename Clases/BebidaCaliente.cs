using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryCafeteria.Clases
{
    internal class BebidaCaliente:Bebida
    {
        private float temperatura;
        
        public float _temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        //constructor parametrizado
        public BebidaCaliente(string nombre, string tamanio, float precio, float temperatura): base(nombre, tamanio, precio)
        {
            this.temperatura = temperatura;
        }

        //metododo sobrescrito (Polimorfismo)
        public override string preparar()
        {
            return $"Preparando un: {nombreBebida} caliente de tamaño: {tamanio}";
        }
    }
}
