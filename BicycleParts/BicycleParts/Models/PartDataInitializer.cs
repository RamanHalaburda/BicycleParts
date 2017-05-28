using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BicycleParts.Models
{
    public class PartDataInitializer : DropCreateDatabaseIfModelChanges<PartContext>
    {
        protected override void Seed(PartContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetParts().ForEach(p => context.Parts.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Frame"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Fork"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Seat"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Seatpost"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Stem"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Bar"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Rim"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Hub"
                },
                new Category
                {
                    CategoryID = 9,
                    CategoryName = "Tire"
                },
                new Category
                {
                    CategoryID = 10,
                    CategoryName = "Tube"
                },
                new Category
                {
                    CategoryID = 11,
                    CategoryName = "Brakes"
                },
                new Category
                {
                    CategoryID = 12,
                    CategoryName = "Grips"
                },
                new Category
                {
                    CategoryID = 13,
                    CategoryName = "Spokes"
                },
                new Category
                {
                    CategoryID = 14,
                    CategoryName = "Rotors"
                },
                new Category
                {
                    CategoryID = 15,
                    CategoryName = "Pegs"
                },
                new Category
                {
                    CategoryID = 16,
                    CategoryName = "Headset"
                },
                new Category
                {
                    CategoryID = 17,
                    CategoryName = "Seatclamp"
                },
                new Category
                {
                    CategoryID = 18,
                    CategoryName = "Shocks"
                },
                new Category
                {
                    CategoryID = 19,
                    CategoryName = "Bearings"
                },
                new Category
                {
                    CategoryID = 20,
                    CategoryName = "Chain"
                },
                new Category
                {
                    CategoryID = 21,
                    CategoryName = "Chainrings"
                },
                new Category
                {
                    CategoryID = 22,
                    CategoryName = "Cassete"
                },
            };

            return categories;
        }

        private static List<Parts> GetParts()
        {
            var parts = new List<Parts> {
                new Parts
                {
                    PartID = 1,
                    PartBrand = "Banshee",
                    PartModel = "Chaparral",
                    Description = "FR, DH", 
                    ImagePath="banaheechaparral.png",
                    PartPrice = 400.99,
                    CategoryID = 1
               }
            };

            return parts;
        }
    }
}