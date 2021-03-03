using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Perceptron
{
     public class PlanePoint
    {
        // X,Y del plano {-5,5}
        private float _X;
        private float _Y;
        public float X { get => _X; set => _X = value; }
        public float Y { get => _Y; set => _Y = value; }        
        

        public PlanePoint(PlanePoint planePoint) {
            this._X = planePoint.X;
            this._Y = planePoint.Y;
        }
        public PlanePoint(float X, float Y)
        {
            this._X = X;
            this._Y = Y;
        }
    }
}
