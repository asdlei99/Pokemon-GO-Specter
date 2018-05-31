using System;
using System.Globalization;
using System.Threading;
using GeoCoordinatePortable;

namespace Specter.Util
{
    public class CoordinatesHelper
    {
        public static double ParaRadianos(double graus)
        {
            return graus * 0.017453292519943295;
        }

        public static double ParaGraus(double radianos)
        {
            return radianos * 180.0 / 3.1415926535897931;
        }

        public static double ToBearing(double radianos)
        {
            return (ParaGraus(radianos) + 360.0) % 360.0;
        }


        public static double DegreeBearing(GeoCoordinate localizaoInicial, GeoCoordinate localizaoDestino)
        {
            double num = ParaRadianos(localizaoDestino.Longitude - localizaoInicial.Longitude);
            double x = Math.Log(Math.Tan(ParaRadianos(localizaoDestino.Latitude) / 2.0 + 0.78539816339744828) / Math.Tan(ParaRadianos(localizaoInicial.Latitude) / 2.0 + 0.78539816339744828));
            if (Math.Abs(num) > 3.1415926535897931)
            {
                num = ((num > 0.0) ? (-(6.2831853071795862 - num)) : (6.2831853071795862 + num));
            }
            return ToBearing(Math.Atan2(num, x));
        }

        public static GeoCoordinate CreateWaypoint(GeoCoordinate localizaoInicial, double distanciaEmMetros, double bearingDegrees)
        {
            double num = distanciaEmMetros / 1000.0 / 6371.0;
            double num2 = ParaRadianos(bearingDegrees);
            double num3 = ParaRadianos(localizaoInicial.Latitude);
            double num4 = ParaRadianos(localizaoInicial.Longitude);
            double num5 = Math.Asin(Math.Sin(num3) * Math.Cos(num) + Math.Cos(num3) * Math.Sin(num) * Math.Cos(num2));
            double num6 = num4 + Math.Atan2(Math.Sin(num2) * Math.Sin(num) * Math.Cos(num3), Math.Cos(num) - Math.Sin(num3) * Math.Sin(num5));
            num6 = (num6 + 9.42477796076938) % 6.2831853071795862 - 3.1415926535897931;
            return new GeoCoordinate(ParaGraus(num5), ParaGraus(num6));
        }

        public static double CalculaDistanciaEmMetros(GeoCoordinate localizaoInicial, GeoCoordinate localizaoDestino)
        {
            return CalculaDistanciaEmMetros(localizaoInicial.Latitude, localizaoInicial.Longitude, localizaoDestino.Latitude, localizaoDestino.Longitude);
        }

        public static double CalculaDistanciaEmMetros(double inicialLat, double inicalLong, double destinoLat, double destinoLong)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            GeoCoordinate geoCoordinate = new GeoCoordinate(inicialLat, inicalLong);
            GeoCoordinate outro = new GeoCoordinate(destinoLat, destinoLong);
            return geoCoordinate.GetDistanceTo(outro);
        }

    }
}
