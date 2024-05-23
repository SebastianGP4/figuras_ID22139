using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geometricas
{
    class Triangulo : Figura //CLASE HIJA DE FIGURA
    {
        //esta clase requiere tres lados para funcionar
        //creamos el lado2 y lado3
        //crear un constructor para el triangulo
        private float lado2;
        public float Lado2
        {
            set
            {
                if (value > 0) //pregunta si el lado <0
                {
                    lado2 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado2 = value; //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado2; //regresa o cacha el valor de la variable lado1
            }
        }

        private float lado3;
        public float Lado3
        {
            set
            {
                if (value > 0) //pregunta si el lado <0
                {
                    lado3 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado3 = value; //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado3; //regresa o cacha el valor de la variable lado1
            }
        }

        public Triangulo(float lado1, float lado2, float lado3) 
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }

        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado3 / 2;
        }

        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public override float volumen()
        {
            throw new NotImplementedException(); //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}