using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    class Esfera : Figura //Esta es una clase hija de figura
    {
        //Usamos el constructor de la clase padre
        public Esfera(float radio) 
        {
            Lado1 = radio; //radio se va a leer de la caja de texto con usando el boton guardar
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return 4 * 3.1416F * Lado1 * Lado1; //AGREGAMOS F AL FINAL DE UN NUMERO CUANDO ES UNA CONSTANTE NO DEFINIDA EN UNA VARIABLE PREVIAMENTE, ASI EL PROGRAMA SABE QUE ES UN #
        }

        public override float perimetro()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }

        public override float volumen()
        {
            return 4 / 3 * 3.1416F * Lado1 * Lado1 * Lado1;
        }
    }
}
