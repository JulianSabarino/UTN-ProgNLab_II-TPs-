using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo //noting -> public
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color):base(marca,chasis,color) //(chasis, marca, color) -> (marca,chasis,color)
        {
            this.tipo = ETipo.CuatroPuertas; //tipo -> this.tipo
        }

        /// <summary>
        /// Constructor de tipo para cuatro elementos
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(marca, chasis, color) //(chasis, marca, color) -> (marca,chasis,color)
        {
            this.tipo = tipo; // this.tipo = ETipo.CuatroPuertas -> this.tipo = tipo
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio //short -> override ETamanio
        {
            get
            {
                return ETamanio.Mediano; //this.Tamanio -> ETamanio.Mediano
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar()); //this -> base.Mostrar()
            sb.AppendLine($"TAMAÑO : {this.Tamanio}"); //"TAMAÑO : {0}", this.Tamanio -> 
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); //nothing -> toString()
        }
    }
}
