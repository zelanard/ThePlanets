using System;

namespace ThePlanets.View
{
    /// <summary>
    /// <c>PLanetView</c> controls the input output of of ThePlaets app.
    /// </summary>
    public static class PlanetView
    {
        /// <summary>
        /// prompt the user to press a key.
        /// </summary>
        public static void WaitForKey()
        {
            Msg("");
            Msg("Press any key to continue.");
            Msg("");
            Console.ReadKey();
        }
        /// <summary>
        /// write the mesgae to the console.
        /// </summary>
        /// <param name="message"></param>
        public static void Msg(string message)
        {
            Console.WriteLine(message);
        }
    }
}
