using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetraT
{
    public class Punto
    {
        public float x;
        public float y;
        public float z;

        public Punto(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Punto(Punto punto)
        {
            this.x = punto.x;
            this.y = punto.y;
            this.z = punto.z;
        }

        public static Punto operator +(Punto p1, Punto p2) 
        {
            return new Punto(p1.x+p2.x, p1.y+p2.y, p1.z+p2.z);        
        }
    }
}