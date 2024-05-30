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

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            DATOS.Clear();
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            
        }

        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\cuadrado.png";
                IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
            }
            else 
            {
                if (CÍRCULO.Checked)
                {
                    string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\circulo.png";
                    IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
                }
                else
                { if (TRIÁNGULO.Checked)
                    {
                        string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\triangulo.png";
                        IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
                    }
                else
                    { if (RECTÁNGULO.Checked)
                        {
                            string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\rectangulo.png";
                            IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
                        }
                    else
                        { if (CUBO.Checked)
                            {
                                string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\cubo.png";
                                IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
                            }
                        else
                            { if (ESFERA.Checked)
                                {
                                    string rutaImagen = "C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\esfera.png";
                                    IMAGEN.BackgroundImage = Image.FromFile(rutaImagen);
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
