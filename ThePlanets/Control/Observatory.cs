using ThePlanets.Model;
using ThePlanets.View;

namespace ThePlanets.Control
{
    /// <summary>
    /// The <c>Observatory</c> is the Controller of the app.
    /// </summary>
    internal class Observatory
    {
        private SolarSystem _system;

        public void Start()
        {
            _system = new SolarSystem();
            PlanetView.Msg(_system.ToString());
            PlanetView.Msg("");

            _system.InsertNewPlanet("Venus", (float)4.87, 12104, 5243, (float)8.9, -(float)5832.5, 2802, (float)108.2, (float)224.7, 35, 464, 0, false, 1);
            PlanetView.Msg(_system.ToString());
            PlanetView.Msg("");

            _system.RemovePlanet("Pluto");
            PlanetView.Msg(_system.ToString());
            PlanetView.Msg("");

            _system.InsertNewPlanet("Pluto", (float)0.0146, 2370, 2095, (float)0.7, -(float)153.3, (float)153.3, (float)5906.4, (float)90.56, (float)4.7, -225, 5, false);
            PlanetView.Msg(_system.ToString());
            PlanetView.Msg("");

            PlanetView.Msg($"The solar system has {_system.Planets.Count} planets.");
            PlanetView.Msg("");

            PlanetView.Msg(_system.GetColdPlanets(0));
            PlanetView.Msg("");

            PlanetView.Msg(_system.GetLargePlanets(10000, 50000));
            PlanetView.Msg("");

            _system.Planets.Clear();
            PlanetView.Msg(_system.ToString());
            PlanetView.WaitForKey();
        }
    }
}
