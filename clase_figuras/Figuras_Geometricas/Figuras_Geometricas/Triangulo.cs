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
        private float altura;
        public float Altura
        {
            set
            {
                if (value > 0) //pregunta si el lado <0
                {
                    altura = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    altura = value; //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return altura; //regresa o cacha el valor de la variable lado1
            }
        }
        public Triangulo(float lado1, float altura)
        {
            this.Lado1 = lado1;
            this.Altura = altura;
        }
        //vamos a usar los métodos de la clase padre
        //vamos a sobreesribir el comportamiento de estos
        public override float area()
        {
            return (Lado1 * Altura)/2;
        }
        public override float perimetro()
        {
            return 3 * Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException(); //ESTO ES UNA EXEPCION DE USO DEFAULT DEL SISTEMA
        }
    }
}