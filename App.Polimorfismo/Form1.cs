using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics grafico = CreateGraphics();
            Brush pincel = Brushes.Black;
            
              //Esto es para llamar la clase circulo
            Circulo circunferencia = new Circulo() { alto = 100, ancho = 100, X = 0, Y = 0 };
            circunferencia.EstablecerColor(Color.Green);
            grafico.FillEllipse(circunferencia.ObtenerPincel(), circunferencia.ObtenerFigura());
            grafico.DrawEllipse(Pens.Red, circunferencia.ObtenerFigura());
            


            
              //Esto es para llamar a la clase triangulo
            Triangulo triangulo = new Triangulo() { alto = 100, ancho = 100, X = 0, Y = 0 };
            triangulo.EstablecerColor(Color.Blue);
            int diametro = 100;
            grafico.DrawLine(Pens.Purple, 2, diametro , diametro, 2);
            grafico.DrawPolygon(triangulo.ObtenerLapiz(), triangulo.DibujarTriangulo());
            

            
             
             
            //Instanciamos el objeto circunferencia
            Rectangulo rect = new Rectangulo() { alto = 100, ancho = 100, X = 0, Y = 0 };
            rect.EstablecerColor(Color.Gray);
            //grafico.DrawRectangle (pincel, X, Y, alto, ancho)
            grafico.DrawRectangle(rect.ObtenerLapiz(), rect.ObtenerFigura());

        }
    }
}
