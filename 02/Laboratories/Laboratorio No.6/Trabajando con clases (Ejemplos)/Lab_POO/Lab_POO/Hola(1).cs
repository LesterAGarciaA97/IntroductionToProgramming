using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Librería para poder llamar messagebox

namespace Lab_POO
{
    public class Hola
    {
        //aqui van los atributos
        int resultado;
        string mensaje;        
        double numero;
        char genero; // F femenino M masculino
        bool EstaInscrito; // T si esta inscrito F no está inscrito
        //aqui van los métodos

        //metodo constructor
        public Hola()
        {
            resultado = 1;
            //aca adentro van las acciones del metodo
        }

        //Metodo que se llama MostrarHola
        public void MostrarHola()
        {
            //aca va la funcionalidad del metodo
            MessageBox.Show("Hola Mundo");
        }

        //Metodo que se llama MostrarHello
        public void MostrarHello()
        {
            //aca va la funcionalidad del metodo
            MessageBox.Show("Hello World");
        }

        //Metodo que se llama MostrarOla
        public void MostrarOla()
        {
            //aca va la funcionalidad del metodo
            MessageBox.Show("Ola ke ase");
        }

        //Función que devuelve un dato del tipo que se indica, con dos parámetros.  
        public int MostrarSuma(int numero1, int numero2)
        {
            //aca va la funcionalidad del procedimiento
            resultado = numero1 + numero2;
            return resultado;
            // las funciones siempre devuelven un valor del tipo de dato declarado
        }

        //Método que devuelve un dato del tipo que se indica, con dos parámetros.  
        public void MostrarSumaV2(int numero1, int numero2)
        {
            //aca va la funcionalidad del procedimiento
            resultado = numero1 + numero2;
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString());            
        }

        //Función que devuelve un dato del tipo que se indica, con un parámetro.  
        public void MostrarProducto(int numero1, int numero2)
        {
            //aca va la funcionalidad del procedimiento
            resultado = numero1 * numero2;
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString());            
            // las funciones siempre devuelven un valor del tipo de dato declarado
        }

        public int MostrarProductoV2(int numero1, int numero2)
        {
            //aca va la funcionalidad del procedimiento
            resultado = numero1 * numero2;
            return resultado;
            // las funciones siempre devuelven un valor del tipo de dato declarado
        }
    }
}
