using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Aircraft
    {
        //Atributos
        string ID;
        double currentlong;
        double currentlat;
        double height;
        Bitmap bmp;

        static Bitmap Bmpaircraft = (Bitmap)Image.FromFile(@"..\..\aircraft.png");

        public Aircraft(string ID, double longitude, double latitude, double height)
        {
            this.ID = ID;
            this.currentlong = longitude;
            this.currentlat = latitude;
            this.height = height;
            this.bmp = new Bitmap(Bmpaircraft, new Size(Bmpaircraft.Width / 20, Bmpaircraft.Height / 20)); //Caldra ferho amb el target length i tots els parametres si es pot

        }
        public void setLat(double lat)
        {
            currentlat=lat;
        }
        public void setLong(double longitude)
        {
            currentlong = longitude;
        }
        public void setHeight(double h)
        {
            height = h;
        }
        public double getLat()
        {
            return currentlat;
        }
        public double getLong()
        {
            return currentlong;
        }
        public Bitmap getbmp()
        {
            return bmp;
        }

    }





}
