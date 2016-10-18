using System;
using System.Drawing;

namespace App.Polimorfismo
{
    //Clase Abstracta para obligar a implementar instancias
    abstract class Figura
    {
        //Campo - Atributos
        private Color Color { get; set; }
        public int alto { get; set; }
        public int ancho { get; set; }
        public Size Tamaño
        {
            get
            {
                return new Size(ancho, alto);
            }
            set
            {
                Size temp = value;
                alto = temp.Height;
                ancho = temp.Width;
            }

        }
        public int X { get; set; }
        public int Y { get; set; }

        //Método o función
        /*---------------------------------------------
 Se establecen Virtual para obligar a 
implementar un método con Override
---------------------------------------------*/
        public virtual string Dibujar()
        {
            return "Proceso realizado.";
        }
        public virtual void EstablecerColor(Color otrocolor)
        {
            this.Color = otrocolor;
        }
        public virtual Color ObtenerColor()
        {
            if (this.Color == null)
                return Color.Black;
            return this.Color;
        }
        public virtual Rectangle ObtenerFigura()
        {
            return new Rectangle();
        }
    }
}
