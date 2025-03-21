using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            CentralBuses central = new CentralBuses();

            
            Bus bus1 = new BusPlatinum(101);
            Bus bus2 = new BusGold(102);

            
            bus1.AgregarPasajeros(15);
            bus2.AgregarPasajeros(9);

            
            central.AgregarBus(bus1);
            central.AgregarBus(bus2);

            
            central.MostrarReporte();
        }
    }
}﻿
