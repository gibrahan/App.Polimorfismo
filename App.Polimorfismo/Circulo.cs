using System;
using System.Drawing;

namespace App.Polimorfismo
{
    //Heredad de Figura
    class Circulo : Figura
    {
        //Más atributos
        public int radio
        {
            get
            {
                return alto / 2;
            }
        }

        //Métodos
        public override string Dibujar()
        {
            return "Dibujar Circunferencia";  //return base.Dibujar();
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

        /* ----------------------------------------
              Segmento para dibujar en pantalla
          -------------------------------------------*/
        //Construimos una circunferencia
        public override Rectangle ObtenerFigura()
        {
            Rectangle circunferencia = new Rectangle();
            circunferencia.X = this.X;
            circunferencia.Y = this.Y;
            circunferencia.Width = this.Tamaño.Width;
            circunferencia.Height = this.Tamaño.Height;
            return circunferencia;
        }
        //Construimos el color de relleno
        public Brush ObtenerPincel()
        {
            return new SolidBrush(this.ObtenerColor()); ;
        }
    }
}