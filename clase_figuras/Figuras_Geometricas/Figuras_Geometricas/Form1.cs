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
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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
            INFORMACION.Clear();
            IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.figurasgeoportada);
            DATOS.Clear();
            CUADRADO.Checked = false;
            TRIÁNGULO.Checked = false;
            RECTÁNGULO.Checked = false;
            ESFERA.Checked = false;
            CÍRCULO.Checked = false;
            CUBO.Checked = false;
            PRISMA.Checked = false;
            POLIIRREG.Checked = false;
            POLIREG.Checked = false;
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void CALCULAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (CÍRCULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (TRIÁNGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (POLIIRREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";

            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= " + "\n";
            }
            else if (RECTÁNGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas " + "\n";
            }
        }
        private void DIBUJAR_Click(object sender, EventArgs e) //Se le va dar una funcion para el boton dibujar
        {
            if (CUADRADO.Checked) //Al seleccionar la opcion de cuadrado aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.cuadrado);
            }
            else if (CUBO.Checked) //Al seleccionar la opcion de cubo aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.cubo);
            }
            else if (ESFERA.Checked) //Al seleccionar la opcion de esfera aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.esfera);
            }
            else if (POLIIRREG.Checked) //Al seleccionar la opcion de poligono irregular aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.poliirreg);
            }
            else if (CÍRCULO.Checked) //Al seleccionar la opcion de circulo aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.circulo);
            }
            else if (PRISMA.Checked) //Al seleccionar la opcion de prisma aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.prisma);
            }
            else if (POLIREG.Checked) //Al seleccionar la opcion de poligono regular aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.polireg);
            }
            else if (TRIÁNGULO.Checked) //Al seleccionar la opcion de triangulo aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.triangulo);
            }
            else if (RECTÁNGULO.Checked) //Al seleccionar la opcion de rectangulo aparece una imagen en picturebox
            {
                IMAGEN.Image = (Figuras_Geometricas.Properties.Resources.rectangulo);
            }
        }
        private void CUADRADO_CheckedChanged(object sender, EventArgs e) 
        {
            
        }
        private void TRIÁNGULO_CheckedChanged(object sender, EventArgs e) 
        {
            
        }
        private void RECTÁNGULO_CheckedChanged(object sender, EventArgs e) 
        {
            
        }
        private void CÍRCULO_CheckedChanged(object sender, EventArgs e) 
        {
            
        }
        private void CUBO_CheckedChanged(object sender, EventArgs e) 
        {
            
        }
        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOS DATOS HAN SIDO GUARDADOS" + DATOS.Text, "DATOS DE LA FIGURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EXPORTAR_Click(object sender, EventArgs e)
        {
            try //EXCEPCION
            {
                string filename = @"C:\Users\LENOVO\Documents\DASC\Semestre 4\Programación orientada a objetos 2\POOM2_SGP\clase_figuras\Figuras_Geometricas\Figuras_Geometricas\datos_exportados\datos.txt";
                StreamWriter writer = File.AppendText(filename);
                writer.WriteLine("Datos: " + INFORMACION.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void POLIREG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void POLIIRREG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PRISMA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void INFO_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cuadrado, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (CÍRCULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Círculo, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (RECTÁNGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Rectángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (TRIÁNGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Triángulo, " + "\n" + "Sus lados son:" + "Logitud de lado: " + DATOS.Text;
            }
            else if (POLIIRREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Polígono irregular, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (POLIREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Polígono regular, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cubo, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Esfera, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Prisma, " + "\n" + "Sus datos son:" + DATOS.Text;
            }
        }
    }
}
