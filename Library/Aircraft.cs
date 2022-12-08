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
        double FL;
        double trackNumber;
        double SAC;
        double SIC;

        Bitmap bmp;
        static string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName.ToString();
        public static IDictionary<string, Bitmap> Bmpaircrafts = new Dictionary<string, Bitmap>() { {"SMR", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftSMR.png") }, { "MLAT", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftMLAT.png") }, { "ADSB", (Bitmap)Image.FromFile(path[..(path.Length - 24)] + "Resources\\aircraftADSB.png") } };
        
        public Aircraft(string ID, double longitude, double latitude, double height, string t, double groundSpeed,double FL,double trackNumber,double SAC, double SIC)
        {
            this.ID = ID;
            this.currentlong = longitude;
            this.currentlat = latitude;
            this.height = height;
            this.type = t;
            this.bmp = new Bitmap(Bmpaircrafts[t], new Size(Bmpaircrafts[t].Width / 25, Bmpaircrafts[t].Height / 25)); //Caldra ferho amb el target length i tots els parametres si es pot
            this.trackNumber = trackNumber;
            this.SAC = SAC;
            this.SIC = SIC;
            this.FL = FL;
            this.groundSpeed = groundSpeed;
            
        }
        public void setLat(double lat)
        {
            this.currentlat=lat;
        }
        public void setLong(double longitude)
        {
            this.currentlong = longitude;
        }
        public void setHeight(double h)
        {
            this.height = h;
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
        public void setFL(double fl)
        {
            this.FL = fl;
        }
        public double getFL()
        {
            return this.FL;
        }
        public void setTrackNumber(double t)
        {
            this.trackNumber = t;
        }
        public double getTrackNumber()
        {
            return this.trackNumber;
        }
        public void setSAC(double SAC)
        {
            this.SAC = SAC;
        }
        public double getSAC()
        {
            return this.SAC;
        }
        public void setSIC(double SIC)
        {
            this.SIC = SIC;
        }
        public double getSIC()
        {
            return this.SIC;
        }
    }





}
