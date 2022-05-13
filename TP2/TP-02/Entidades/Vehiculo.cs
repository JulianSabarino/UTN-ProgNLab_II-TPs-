using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Reordenado para ser fiel al diagrama de clases
/// </summary>

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Enums, Props and Atributes
        public enum EMarca 
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        protected enum ETamanio 
        {
            Chico, Mediano, Grande
        }
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; } 

        #endregion

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}\r\n");
            sb.AppendLine($"MARCA : {p.marca.ToString()}\r\n");
            sb.AppendLine($"COLOR : {p.color.ToString()}\r\n");
            sb.AppendLine("---------------------");
            sb.AppendLine($"TAMAÑO : {p.Tamanio.ToString()}");
            return sb.ToString(); 
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns> 

        public virtual string Mostrar() 
        {
            return (String)this; 
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        #region Constructor base
        ///<summary>
        /// Constructor base
        /// </summary>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }
        #endregion


        /*
        ///<summary>
        /// Eliminamos los warning
        /// </summary>

        public override bool Equals(object v)
        {
            Vehiculo vehiculo = v as Vehiculo;
            return vehiculo != null && this == vehiculo;
        }

        public override int GetHashCode()
        {
            return this.chasis.GetHashCode();
        }
        */
    }
}
