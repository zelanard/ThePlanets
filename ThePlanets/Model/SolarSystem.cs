using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThePlanets.Model
{
    /// <summary>
    /// <c>SolarSystem</c> Models a solar system.
    /// </summary>
    public class SolarSystem
    {
        private List<Planet> _planets;
        internal List<Planet> Planets
        {
            get { return _planets; }
            set { _planets = value; }
        }
        public SolarSystem()
        {
            Planets = new List<Planet>();
            InsertNewPlanet("Pluto", (float)0.0146, 2370, 2095, (float)0.7, -(float)153.3, (float)153.3, (float)5906.4, (float)90.56, (float)4.7, -225, 5, false);
            InsertNewPlanet("Neptun", 102, 49528, 1638, 11, (float)16.1, (float)16.1, (float)4495.1, (float)59.8, (float)5.4, -200, 14, true);
            InsertNewPlanet("Uranus", (float)86.8, 51118, 1271, (float)8.7, -(float)17.2, (float)17.2, (float)2872.5, (float)30.589, (float)6.8, -195, 27, true);
            InsertNewPlanet("Saturn", 568, 120536, 687, 9, (float)10.7, (float)10.7, (float)1433.5, (float)10.747, (float)9.7, -140, 62, true);
            InsertNewPlanet("Jupiter", 1898, 142984, 1326, (float)23.1, (float)9.9, (float)9.9, (float)778.6, 4331, (float)13.1, -110, 67, true);
            InsertNewPlanet("Mars", (float)0.642, 6792, 3933, (float)3.7, (float)24.6, (float)24.7, (float)227.9, 687, (float)24.1, -65, 2, false);
            InsertNewPlanet("Jorden", (float)5.97, 12756, 5514, (float)9.8, (float)23.9, 24, (float)149.6, (float)365.2, (float)29.8, 15, 1, false);
            InsertNewPlanet("Merkur", (float)0.33, 4879, 5427, (float)3.7, (float)1407.6, (float)4222.6, (float)57.9, 88, (float)47.4, 167, 0, false);
        }

        /// <summary>
        /// Inserts a new planet into the list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mass"></param>
        /// <param name="diameter"></param>
        /// <param name="density"></param>
        /// <param name="gravity"></param>
        /// <param name="rotationPeriod"></param>
        /// <param name="lengthofDay"></param>
        /// <param name="distancefromSun"></param>
        /// <param name="orbitalPeriod"></param>
        /// <param name="orbitalVelocity"></param>
        /// <param name="meanTemperature"></param>
        /// <param name="numberofMoons"></param>
        /// <param name="ringSystem"></param>
        /// <param name="index"></param>
        public void InsertNewPlanet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature, byte numberofMoons, bool ringSystem, int index = 0)
        {
            Planets.Insert(index, new Planet(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun, orbitalPeriod, orbitalVelocity, meanTemperature, numberofMoons));
        }
        
        /// <summary>
        /// Remove a planet from the list.
        /// </summary>
        /// <param name="name"></param>
        public void RemovePlanet(string name)
        {
            foreach(Planet planet in Planets)
            {
                if(planet.Name == name)
                {
                    Planets.Remove(planet);
                    RemovePlanet(name);
                    return;
                }
            }
        }
        
        /// <summary>
        /// Get planets with a temprature colder than temp.
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>string</returns>
        public string GetColdPlanets(int temp)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planet planet in Planets.Where(item => item.MeanTemperature < temp).ToList())
            {
                sb.AppendLine(planet.ToString());
            }
            return sb.ToString();
        }
        
        /// <summary>
        /// Get planets with a diameter between lower and greater.
        /// </summary>
        /// <param name="lower"></param>
        /// <param name="uppper"></param>
        /// <returns>string</returns>
        public string GetLargePlanets(int lower, int uppper)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planet planet in Planets.Where(item => item.Diameter > lower && item.Diameter < uppper).ToList())
            {
                sb.AppendLine(planet.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Output a list of planets with all their data.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Planet planet in Planets)
            {
                sb.AppendLine(planet.ToString());
            }
            return sb.ToString();
        }
    }
}
