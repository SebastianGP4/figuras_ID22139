using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraGeometrica
{
    class Cuadrado : Figura //Esta es una clase hija de Figura
    {
        //usamos el constructor de la clase padre
        public Cuadrado(float lado)
        {   //lado se va a leer de la caja de texto con usando el boton guardar
            Lado1 = lado;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area() //Aquí se calcula el área
        {
            return Lado1 * Lado1;
        }

        public override float perimetro() //Aquí se calcula el perímetro
        {
            return Lado1 + Lado1 + Lado1 + Lado1;
        }

        public override float volumen() //Aquí se calcula el volumen, al ser una figura de dos dimensiones se hace una exepcion
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}