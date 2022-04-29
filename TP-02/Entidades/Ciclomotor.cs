using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base(marca, chasis, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio //short -> override ETamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public override sealed string Mostrar()//private -> public
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());//this -> base
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");//"TAMAÑO : {0}", this.Tamanio -> $"TAMAÑO : {this.Tamanio}"
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //nothing -> ToString()
        }
    }
}
