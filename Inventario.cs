using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_de_vehiculos
{
    class Inventario // esta clase e crea con la finalidad de que trabajaremos en ella con los datos que ingresemos
    {
        /// <summary>
        /// El vehiculo lo utilizaremos en privado para no modificar los datos desde afuera
        ///  y se hace uso de un vector donde almacenaremos temporalmente los datos
        ///  le daremos el nombre de inventario
        /// </summary>
        private Vehiculo[] _inventario;  
        private int Numero_Vehiculos; // va hacer el numero limite de los vehiculos
        /// <summary>
        /// hacemos ya uso delconstructo donde decido el numero de registros permitidos en el _inventario
        /// y haremos un contador para que este nos haga el conteo de los registros
        /// </summary>
        public Inventario() 
        {
            _inventario = new Vehiculo[15]; // inventario su valor maximo de registros es de 15
            for(int i=0; i<15; i++) // iniciamos desde cero
            {
                _inventario[i] = null; // si inventario tiene valor nulo
                Numero_Vehiculos = 0; // el valor de vehiculos es cero
            }
        }
        /// <summary>
        ///  Hacemos el metodo de agregar utilizando Vehiculo
        /// Hay una Variable Que Es V y se asignan los valores
        /// </summary>
        /// <param name="V"></param>
        public void Agregar(Vehiculo V)
        {
            if (Numero_Vehiculos < 15) // si el  numero de vehiculos es menor de 15 sigue agregando
                _inventario[Numero_Vehiculos++] = V;
        }
        /// <summary>
        /// vamos a usar la informacion que esta ya en la clase vehiculo para buscar registrs
        /// con ayuda de la placa
        /// </summary>
        /// <param name="Placa"></param>
        /// <returns></returns>
        public Vehiculo Buscar(string  Placa) 
        {
            Vehiculo V = _inventario[0]; //iniciamos
            for (int i = 0; i < Numero_Vehiculos; i++) // se hace el contador para ver hasa donde llega y si esta un registro
                // con esa numero de placa se detiene hasta ahi
            if (Placa == _inventario[i].Placas) // si placa es igual a un valor de inventario en las placas has lo siguiente
                {
                    V = _inventario[i]; // V obtiene el valor del inventario
                    break; // Rompe el ciclo
                }
                else // si no obtienes un valor nulo
                {
                    V = null;
                }
            return V; // regresa el valor que se le asigno a ve ya sea con los datos de un registro o con un valor nulo
             
        }
        public Vehiculo insertar(int posicion, Vehiculo V)
        {
            //Vehiculo V = _inventario[0];
            if (posicion < Numero_Vehiculos)
            {  
                int temporal = posicion;
                for (int j = Numero_Vehiculos; j > temporal; j--)
                    _inventario[j]=_inventario[j-1];
                _inventario[temporal] = V; 
                Numero_Vehiculos++;
               }
            return V;      
        }
        public void Eliminar(string Placa) // este metodo nos ayudara  a eliminar los regristos del inventario con ayuda de la placa
        {
            for (int i = 0; i < Numero_Vehiculos; i++) // iniciamos en contador para que cheque en que registro esta el numero de la placa
                if (Placa == _inventario[i].Placas) // si laplaca es igual a un regristro de el inventario entonces
                {
                    for(int j=i+1;j<Numero_Vehiculos; j++)
                    {
                        _inventario[i - 1]=_inventario[j];
                    }
                    _inventario[Numero_Vehiculos--]=null;
                    break;
                }
        }
       
        public string Lista() //hacemos la lista de los registro de el invenario
        {
            string Lista=""; // Nos ayudara a regresar un valor
            for (int i = 0; i < Numero_Vehiculos; i++) // iniciamos el contador para ver todos los regristros que tiene
                // y haci poder sacar la informacion
            {
                Lista += _inventario[i] + Environment.NewLine + Environment.NewLine; //si hay un registro ve agrendandolo a la lista con dos saltos de line para separarlo registros
            }
            return Lista; // Regresa el valor asignado a la lista
        }
        public override string ToString()
        {
            return Numero_Vehiculos.ToString();
        }
    }
}
