using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cubo : Figura //Esta es una clase hija de Figura
    {
        //usamos el constructor de la clase padre
        public Cubo(float arista)
        {   //lado se va a leer de la caja de texto con usando el boton guardar
            Lado1 = arista;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area() //Aquí se calcula el área
        {
            return 6 * (Lado1 * Lado1);

        }
        public override float perimetro() //Aquí se calcula el perímetro, al ser una figura de dos dimensiones se hace una exepcion
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }

        public override float volumen() //Aquí se calcula el volumen
        {
            return Lado1 * Lado1 * Lado1;
        }
    }
}