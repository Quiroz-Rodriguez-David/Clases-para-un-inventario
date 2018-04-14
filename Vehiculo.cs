using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_vehiculos
{
    class Vehiculo // se crea esta clase ya que es lo  que contendra cada aut o vehiculo en general
    {
        private string _Placas; //  placas ejemplo=392031 
        public string Placas { get { return _Placas; } } // me regresa e valor de las placas
        private string _Marca; // marca
        public string Marca{ get { return _Marca; } } //regresa la marc del vehiculo
        private string _Modelo; // modelo del vehiculo  
        public string Modelo { get{ return _Modelo; } } // regresa modelo
        private string _Telefono;
        public string Telefono { get{ return _Telefono; } }
        private string _Anio;
        public string Anio { get{ return _Anio; } }
        /// <summary>
        ///  es el constructor que mandara pedri datos que son los siguientes
        /// </summary>
        /// <param name="placas"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="telefono"></param>
        /// <param name="anio"></param>
        public Vehiculo(string placas,string marca,string modelo,string telefono, string anio) 
        {
            _Placas = placas; //placas obtiene el mismo valor de _placas al igaul que en los demas terminos
            _Marca = marca;
            _Modelo = modelo;
            _Telefono = telefono;
            _Anio = anio;
        }
        public override string ToString()   
        { // mandamos los valores atraves del override string con el mensaje que le deseemos agregar a cada metodo
            return "Placas: " + Placas.ToString()+ Environment.NewLine + "Marca: "+Marca +Environment.NewLine 
                + "Modelo: "+ Modelo + Environment.NewLine +"Telefono de la compañia: "+ Telefono.ToString() + Environment. NewLine 
                +"Año:"+Anio.ToString()+ Environment.NewLine;
        }

    }
}
