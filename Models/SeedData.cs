using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpringPI.Data;
using System;
using System.Linq;

namespace SpringPI.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SpringPIContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SpringPIContext>>()))
        {
            // Look for any movies.
            if (context.Furniture.Any())
            {
                return;   // DB has been seeded
            }
            context.Furniture.AddRange(
                new Furniture 
                {
                    Room = "Kitchen",
                    Type = "Countertop",
                    Brand = "HavenHome",
                    Colour = "Oak",
                    Price = 799M
                },
                new Furniture
                {
                    Room = "Washroom",
                    Type = "Vanity",
                    Brand = "StylishSanctuary",
                    Colour = "Ivory",
                    Price = 899M
                },
                new Furniture
                {
                    Room = "Living Room",
                    Type = "Couch",
                    Brand = "SereneSeating",
                    Colour = "Cerulean",
                    Price = 799M
                },
                new Furniture
                {
                    Room = "Dining Room",
                    Type = "Table",
                    Brand = "UrbanNest",
                    Colour = "Pine",
                    Price = 899M
                },
                new Furniture
                {
                    Room = "Patio",
                    Type = "Swinging Chair",
                    Brand = "LuxeLounge",
                    Colour = "Blue",
                    Price = 999M
                },
                new Furniture
                {
                    Room = "Bedroom",
                    Type = "Dresser",
                    Brand = "UrbanNest",
                    Colour = "Mahogany",
                    Price = 399M
                },
                new Furniture
                {
                    Room = "Living Room",
                    Type = "Ottoman",
                    Brand = "SereneSeating",
                    Colour = "Plaid",
                    Price = 799M
                },
                new Furniture
                {
                    Room = "Bedroom",
                    Type = "Mattress",
                    Brand = "PoshPillows",
                    Colour = "Floral",
                    Price = 899M
                },
                new Furniture
                {
                    Room = "Living Room",
                    Type = "Recliner",
                    Brand = "LuxeLounge",
                    Colour = "Teal",
                    Price = 999M
                },
                new Furniture
                {
                    Room = "Living Room",
                    Type = "Coffee Table",
                    Brand = "UrbanNest",
                    Colour = "Pine",
                    Price = 399M
                }
            );
            context.SaveChanges();
        }
    }
}