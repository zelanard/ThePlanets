namespace ThePlanets.Model
{
    /// <summary>
    /// <c>Planet</c> models a planet.
    /// </summary>
    public class Planet
    {
        #region Properties
        private string _name;
        private float _mass;
        private int _diameter;
        private short _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _lengthofDay;
        private float _distancefromSun;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private short _meanTemperature;
        private byte _numberofMoons;
        private bool _ringSystem;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public float Mass
        {
            get { return _mass; }
            private set { _mass = value; }
        }
        public int Diameter
        {
            get { return _diameter; }
            private set { _diameter = value; }
        }
        public short Density
        {
            get { return _density; }
            private set { _density = value; }
        }
        public float Gravity
        {
            get { return _gravity; }
            private set { _gravity = value; }
        }
        public float RotationPeriod
        {
            get { return _rotationPeriod; }
            private set { _rotationPeriod = value; }
        }
        public float LengthofDay
        {
            get { return _lengthofDay; }
            private set { _lengthofDay = value; }
        }
        public float DistancefromSun
        {
            get { return _distancefromSun; }
            private set { _distancefromSun = value; }
        }
        public float OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            private set { _orbitalPeriod = value; }
        }
        public float OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            private set { _orbitalVelocity = value; }
        }
        public short MeanTemperature
        {
            get { return _meanTemperature; }
            private set { _meanTemperature = value; }
        }
        public byte NumberofMoons
        {
            get { return _numberofMoons; }
            private set { _numberofMoons = value; }
        }
        public bool RingSystem
        {
            get { return _ringSystem; }
            private set { _ringSystem = value; }
        }

        #endregion

        #region Constructors
        public Planet()
        {
            string _name = "Unnamed Planet";
            float _mass = 0;
            int _diameter = 0;
            short _density = 0;
            float _gravity = 0;
            float _rotationPeriod = 0;
            float _lengthofDay = 0;
            float _distancefromSun = 0;
            float _orbitalPeriod = 0;
            float _orbitalVelocity = 0;
            short _meanTemperature = 0;
            byte _numberofMoons = 0;
            bool _ringSystem = false;
        }
        public Planet(string name) : this()
        {
            Name = name;
        }
        public Planet(string name, float mass) : this(name)
        {
            Mass = mass;
        }
        public Planet(string name, float mass, int diameter) : this(name, mass)
        {
            Diameter = diameter;
        }
        public Planet(string name, float mass, int diameter, short density) : this(name, mass, diameter)
        {
            Density = density;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity) : this(name, mass, diameter, density)
        {
            Gravity = gravity;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod) : this(name, mass, diameter, density, gravity)
        {
            RotationPeriod = rotationPeriod;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay) : this(name, mass, diameter, density, gravity, rotationPeriod)
        {
            LengthofDay = lengthofDay;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay)
        {
            DistancefromSun = distancefromSun;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun)
        {
            OrbitalPeriod = orbitalPeriod;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod, float orbitalVelocity) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun, orbitalPeriod)
        {
            OrbitalVelocity = orbitalVelocity;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun, orbitalPeriod, orbitalVelocity)
        {
            MeanTemperature = meanTemperature;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature, byte numberofMoons) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun, orbitalPeriod, orbitalVelocity, meanTemperature)
        {
            NumberofMoons = numberofMoons;
        }
        public Planet(string name, float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthofDay, float distancefromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature, byte numberofMoons, bool ringSystem) : this(name, mass, diameter, density, gravity, rotationPeriod, lengthofDay, distancefromSun, orbitalPeriod, orbitalVelocity, meanTemperature, numberofMoons)
        {
            RingSystem = ringSystem;
        }

        #endregion

        /// <summary>
        /// Get all planet data.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"" +
                $"Name: {Name}, " +
                $"Mass: {Mass}, " +
                $"Diameter: {Diameter}, " +
                $"Density: {Density}, " +
                $"Gravity: {Gravity}, " +
                $"RotationPeriod: {RotationPeriod}, " +
                $"LengthofDay: {LengthofDay}, " +
                $"DistancefromSun: {DistancefromSun}, " +
                $"OrbitalPeriod: {OrbitalPeriod}, " +
                $"OrbitalVelocity: {OrbitalVelocity}, " +
                $"MeanTemperature: {MeanTemperature}, " +
                $"NumberofMoons: {NumberofMoons}, " +
                $"RingSystem: {RingSystem}" +
                $"";
        }

    }
}
