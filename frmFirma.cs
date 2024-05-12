using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLab3
{
    public partial class Form1 : Form
    {
        private Point? previousPoint;
        private Pen pen;
        private Bitmap firmaBitmap = new Bitmap(382, 217);
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 2); // Color y grosor del trazo
            pictureBox1.BackColor = Color.White; // Color de fondo del PictureBox

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            previousPoint = e.Location;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            previousPoint = null;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (previousPoint != null && e.Button == MouseButtons.Left)
            {
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawLine(pen, previousPoint.Value, e.Location);
                }
                previousPoint = e.Location;
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Refresh(); // Limpia la firma
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres guardar la firma?", "Confirmación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta "Firmas" en relación con la ubicación del ejecutable
                string carpetaFirmas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Firmas");

                // Verificar si la carpeta "Firmas" existe, si no, crearla
                if (!Directory.Exists(carpetaFirmas))
                {
                    Directory.CreateDirectory(carpetaFirmas);
                }

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Construir el nombre de archivo con la fecha y hora actual
                string nombreArchivo = $"{fechaActual:yyyyMMdd_HHmm}.jpg";

                // Combinar la ruta de la carpeta "Firmas" con el nombre de archivo
                string rutaCompleta = Path.Combine(carpetaFirmas, nombreArchivo);

                // Guardar la imagen en la ruta especificada
                firmaBitmap.Save(rutaCompleta, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Limpiar la firma en pantalla
                using (Graphics papel = Graphics.FromImage(firmaBitmap))
                {
                    papel.Clear(Color.White);
                }
                pictureBox1.Refresh();
            }
        }
    }
}


