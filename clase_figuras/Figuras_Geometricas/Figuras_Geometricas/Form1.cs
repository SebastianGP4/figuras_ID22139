using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de esfera aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\esfera.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            DATOS.Clear();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked || CÍRCULO.Checked || CUBO.Checked || ESFERA.Checked || POLIIRREG.Checked || POLIREG.Checked || PRISMA.Checked || RECTÁNGULO.Checked || TRIÁNGULO.Checked) //El mensaje se va a mostrar para todas las figuras
            {
                MessageBox.Show("El resultado es = " + DATOS.Text);
            }
            else
            {
                MessageBox.Show("ERROR, para calcular selecciona una figura"); //Se muestra una ventana con un mensaje para el usuario indicando que hay un error
            }
        }
        private void DIBUJAR_Click(object sender, EventArgs e) //Se le va dar una funcion para el boton dibujar
        {
            if (CUADRADO.Checked)
            {
                string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\cuadrado.png"; //Va aparecer una imagen de la figura
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else
            {
                if (CÍRCULO.Checked)
                {
                    string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\circulo.png"; //Va aparecer una imagen de la figura
                    IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
                }
                else
                {
                    if (CUBO.Checked)
                    {
                        string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\cubo.png"; //Va aparecer una imagen de la figura
                        IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
                    }
                    else
                    {
                        if (ESFERA.Checked)
                        {
                            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\esfera.png"; //Va aparecer una imagen de la figura
                            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
                        }
                        else
                        {
                            if (TRIÁNGULO.Checked)
                            {
                                string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\triangulo.png"; //Va aparecer una imagen de la figura
                                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
                            }
                            else
                            {
                                if (RECTÁNGULO.Checked)
                                {
                                    string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\rectangulo.png"; //Va aparecer una imagen de la figura
                                    IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
                                }
                                else
                                {
                                    MessageBox.Show("ERROR, para dibujar selecciona una figura"); //Se muestra una ventana con un mensaje para el usuario indicando que hay un error
                                }
                            }
                        }
                    }
                }
            }
        }
        private void CUADRADO_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de cuadrado aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\cuadrado.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }
        private void TRIÁNGULO_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de triangulo aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\triangulo.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }
        private void RECTÁNGULO_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de rectangulo aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\rectangulo.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }
        private void CÍRCULO_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de circulo aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\circulo.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }
        private void CUBO_CheckedChanged(object sender, EventArgs e) //Al seleccionar la opcion de cubo aparece una imagen en picturebox
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\clase_figuras\\Figuras_Geometricas\\Resources\\cubo.png";
            IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
        }
        private void GUARDAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked || CÍRCULO.Checked || CUBO.Checked || ESFERA.Checked || POLIREG.Checked || POLIIRREG.Checked || PRISMA.Checked || RECTÁNGULO.Checked || TRIÁNGULO.Checked) //El mensaje se va a mostrar para todas las figuras
            {
                MessageBox.Show("Los datos han sido guardados"); //Se muestra una ventana con un mensaje para el usuario indicando que los datos se guardaron
            }
            else
            {
                MessageBox.Show("ERROR, para guadar los datos selecciona una figura"); //Se muestra una ventana con un mensaje para el usuario indicando que hay un error
            }
        }   
    }
}
