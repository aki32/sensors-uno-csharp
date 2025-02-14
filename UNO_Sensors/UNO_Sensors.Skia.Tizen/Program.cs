﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UNO_Sensors.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UNO_Sensors.App(), args);
            host.Run();
        }
    }
}
