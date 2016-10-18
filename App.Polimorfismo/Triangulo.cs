using System;
using System.Drawing;

namespace App.Polimorfismo
{
    class Triangulo : Figura
    {
        //Métodos
        public override string Dibujar()
        {
            return "Dibujar Triangulo";  //return base.Dibujar();
        }
        //Nuevo color
        public override void EstablecerColor(Color otrocolor)
        {
            if (otrocolor == null)
                base.EstablecerColor(Color.Black);
            else
                base.EstablecerColor(otrocolor);
        }
        //Regresamos el color
        public override Color ObtenerColor()
        {
            return base.ObtenerColor();
        }
        //Construimos un triángulo
        public override Rectangle ObtenerFigura()
        {
            Rectangle contorno = new Rectangle();
            contorno.X = this.X;
            contorno.Y = this.Y;
            contorno.Width = this.Tamaño.Width;
            contorno.Height = this.Tamaño.Height;
            return contorno;
        }
        //Construimos un triángulo
        public Point[] DibujarTriangulo()
        {
            Point A = new Point(0, alto);
            Point B = new Point((ancho / 2), 0);
            Point C = new Point(ancho, alto);
            Point[] list = new Point[] { A, B, C };
            return list;
        }
        //Construimos el color de relleno
        public Pen ObtenerLapiz()
        {
            return new Pen(this.ObtenerColor()); ;
        }
    }
}
