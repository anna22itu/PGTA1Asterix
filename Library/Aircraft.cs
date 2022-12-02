using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class Aircraft
    {
        //Atributos
        string ID;
        string type;
        double currentlong;
        double currentlat;
        double height;
        double groundSpeed;

        Bitmap bmp;
        static string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName.ToString();
        public static IDictionary<string, Bitmap> Bmpaircrafts = new Dictionary<string, Bitmap>() { {"SMR", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftSMR.png") }, { "MLAT", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftMLAT.png") }, { "ADSB", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftADSB.png") } };
        public Aircraft(string ID, double longitude, double latitude, double height, string t, double groundSpeed)
        {
            this.ID = ID;
            this.currentlong = longitude;
            this.currentlat = latitude;
            this.height = height;
            this.type = t;
            this.bmp = new Bitmap(Bmpaircrafts[t], new Size(Bmpaircrafts[t].Width / 25, Bmpaircrafts[t].Height / 25)); //Caldra ferho amb el target length i tots els parametres si es pot
            this.groundSpeed = groundSpeed;
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
        public void setGroundSpeed(double g)
        {
            groundSpeed = g;
        }
        public double getGroundSpeed()
        {
            return groundSpeed;
        }
        public string getType()
        { 
            return type;
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

        public String getID()
        {
            return ID;
        }
    }





}
