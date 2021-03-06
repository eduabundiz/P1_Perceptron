﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Perceptron
{
    public static class PointController
    {
        private const float DIVISIONES = 5;

        #region pixelsToPlane
        // Dados puntos x,y en pixeles del bitmap convierte a coordenada  {5,5} clase PlanePoint
        public static PlanePoint pixelsToPlane(int pX,int pY, Bitmap bmp)
        {
            float width = bmp.Width;
            float height = bmp.Height;            
            float x, y;
            // x = point.X - mitadAncho            
            x = pX - (width / 2); //Convierte el punto a coordenada
            x = x / (width / 2) * DIVISIONES; //Convierte coordenada a limite {5,5}

                        

            //Si el punto y está en la parte de arriba
            if (pY <= height / 2)
            {
                y = height / 2 - pY; // restar la mitad de altura menos el punto y
                
            }
            else
            {
                y = -1 * (pY - height / 2); // Si es abajo, es negativo y es el punto menos la mitad
            }

            y = y / (height / 2) * DIVISIONES; // Regla de 3 para convertir A LIMITE de {5,5}
            
            return new PlanePoint(x, y);
        }
        public static PlanePoint pixelsToPlane(Point point,Bitmap bmp)
        {
           return pixelsToPlane(point.X, point.Y, bmp);

        }
        #endregion

        #region planeToPixels
        public static Point planeToPixels(double x, double y, Bitmap bmp)
        {
            Point point = new Point();

            double ex = x;
            double ey = y;

            ex = ex / DIVISIONES * (bmp.Width / 2);
            ex = ex + (bmp.Width / 2);
            point.X = Convert.ToInt32(Math.Round(ex));

            ey = ey / DIVISIONES * (bmp.Height / 2);
            

            if(ey>= 0)
            {
                ey = bmp.Height / 2 - ey;                
            }
            else
            {
                ey *= -1;
                ey = ey + bmp.Height / 2;
            }            
            point.Y = Convert.ToInt32(Math.Round(ey));

            return point;
        }
        public static Point planeToPixels(PlanePoint pp,Bitmap bmp)
        {
            return planeToPixels(pp.X,pp.Y,bmp);
        }
        #endregion

    }

}
