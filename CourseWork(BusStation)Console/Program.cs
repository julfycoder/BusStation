using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseWork_BusStation_Console.Model.WorkingWithDatabase;
using CourseWork_BusStation_Console.Model.BusStationEntity;
using System.Data;
using System.Reflection;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CourseWork_BusStation_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.BusStationAccess station = new Model.BusStationAccess();

            station.ChangeEntity(new Flight()
            {
                idFlight = 19
            }, new Flight()
            {
                Intermediate_stops="Belgorod"
            });

            List<Flight> flights = station.GetEntities<Flight>();


            //List<Ticket> tickets = station.GetTickets();
            //List<Passenger> passengers = station.GetPassengers();
            //List<Driver> drivers = station.GetDrivers();
            //List<Bus> buses = station.GetBuses();

            //List<Flight> flights = station.GetEntitiesByPrototype(new Flight() { Departure_place = "Киев"});

            DrawFlights(flights);
            //Console.WriteLine();
            //DrawTickets(tickets);
            //Console.WriteLine();
            //DrawPassengers(passengers);
            //Console.WriteLine();
            //DrawDrivers(drivers);
            //Console.WriteLine();
            //DrawBuses(buses);

            Console.ReadLine();
        }
        static string Process<T>()
        {
            return typeof(T).Name;
        }
        static void DrawFlights(List<Flight> collection)
        {
            foreach (PropertyInfo property in new Flight().GetType().GetProperties())
            {
                Console.Write(property.Name + "\t");
            }
            Console.WriteLine();
            foreach (object entity in collection)
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    Console.Write(property.GetValue(entity, null) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void DrawDrivers(List<Driver> collection)
        {
            foreach (PropertyInfo property in new Driver().GetType().GetProperties())
            {
                Console.Write(property.Name + "\t");
            }
            Console.WriteLine();
            foreach (object entity in collection)
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    Console.Write(property.GetValue(entity, null) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void DrawBuses(List<Bus> collection)
        {
            foreach (PropertyInfo property in new Bus().GetType().GetProperties())
            {
                Console.Write(property.Name + "\t");
            }
            Console.WriteLine();
            foreach (object entity in collection)
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    Console.Write(property.GetValue(entity, null) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void DrawPassengers(List<Passenger> collection)
        {
            foreach (PropertyInfo property in new Passenger().GetType().GetProperties())
            {
                Console.Write(property.Name + "\t");
            }
            Console.WriteLine();
            foreach (object entity in collection)
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    Console.Write(property.GetValue(entity, null) + "\t");
                }
                Console.WriteLine();
            }
        }

        static void DrawTickets(List<Ticket> collection)
        {
            foreach (PropertyInfo property in new Ticket().GetType().GetProperties())
            {
                Console.Write(property.Name + "\t");
            }
            Console.WriteLine();
            foreach (object entity in collection)
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    Console.Write(property.GetValue(entity, null) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
