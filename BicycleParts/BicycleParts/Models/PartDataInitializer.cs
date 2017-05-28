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
                new Category
                {
                    CategoryID = 23,
                    CategoryName = "Springs"
                }
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
               },
               new Parts
                {
                    PartID = 2,
                    PartBrand = "RockShox",
                    PartModel = "Domain 302",
                    Description = "coil", 
                    ImagePath="rsdomain.png",
                    PartPrice = 140.49,
                    CategoryID = 2
               },
               new Parts
                {
                    PartID = 3,
                    PartBrand = "WTB",
                    PartModel = "Silverado",
                    Description = "Ti rails", 
                    ImagePath="wtb.png",
                    PartPrice = 70.20,
                    CategoryID = 3
               },
               new Parts
                {
                    PartID = 4,
                    PartBrand = "RaceFace",
                    PartModel = "Evolve",
                    Description = "XC", 
                    ImagePath="rfevolve.png",
                    PartPrice = 19.99,
                    CategoryID = 4
               },
               new Parts
                {
                    PartID = 5,
                    PartBrand = "Kore",
                    PartModel = "Torsion",
                    Description = "35mm", 
                    ImagePath="koretorsion.png",
                    PartPrice = 45.10,
                    CategoryID = 5
               },
               new Parts
                {
                    PartID = 6,
                    PartBrand = "Sixpack",
                    PartModel = "Evo",
                    Description = "31.8, 785mm", 
                    ImagePath="sixpack.png",
                    PartPrice = 35.80,
                    CategoryID = 6
               },
               new Parts
                {
                    PartID = 7,
                    PartBrand = "Sapnk",
                    PartModel = "Subrosa",
                    Description = "32 mm, 26 inches, 32 spokes", 
                    ImagePath="spanksubrosa.png",
                    PartPrice = 90.10,
                    CategoryID = 7
               },
               new Parts
                {
                    PartID = 8,
                    PartBrand = "PrideStreet",
                    PartModel = "SWAG",
                    Description = "14 mm axel, 110 width, 32 spokes, 9T driver", 
                    ImagePath="psswag.png",
                    PartPrice = 170.60,
                    CategoryID = 1
               },
               new Parts
                {
                    PartID = 9,
                    PartBrand = "Schwalbe",
                    PartModel = "Racing Ralph",
                    Description = "2,1 width, 26 inches, folding", 
                    ImagePath="schwalberr.png",
                    PartPrice = 26.93,
                    CategoryID = 9
               },
               new Parts
                {
                    PartID = 10,
                    PartBrand = "Duro",
                    PartModel = "Simple",
                    Description = "1.9 - 2.2", 
                    ImagePath="duro.png",
                    PartPrice = 2.20,
                    CategoryID = 10
               },
               new Parts
               {
                    PartID = 11,
                    PartBrand = "Sram",
                    PartModel = "DB5",
                    Description = "front and rear, 1000 mm and 1700 mm", 
                    ImagePath="sramdb5.png",
                    PartPrice = 190.25,
                    CategoryID = 11
               },
               new Parts
               {
                    PartID = 12,
                    PartBrand = "DaBomb",
                    PartModel = "Skeleton",
                    Description = "double lock", 
                    ImagePath="skeleton.png",
                    PartPrice = 21.20,
                    CategoryID = 12
               },
               new Parts
               {
                    PartID = 13,
                    PartBrand = "Sapim",
                    PartModel = "Hard",
                    Description = "2.4 - 1.8 - 2.4", 
                    ImagePath="sapim.png",
                    PartPrice = 0.20,
                    CategoryID = 13
               },
               new Parts
                {
                    PartID = 14,
                    PartBrand = "Avid",
                    PartModel = "G2 CS",
                    Description = "203 mm, direct mount", 
                    ImagePath="avidg2.png",
                    PartPrice = 18.99,
                    CategoryID = 14               
               },
               new Parts
               {
                    PartID = 15,
                    PartBrand = "Stress",
                    PartModel = "Plast",
                    Description = "two plastic pegs", 
                    ImagePath="stressplast.png",
                    PartPrice = 9.30,
                    CategoryID = 15
               },
               new Parts
               {
                    PartID = 16,
                    PartBrand = "CaneKreek",
                    PartModel = "Fourty",
                    Description = "1.1/8", 
                    ImagePath="canekreek.png",
                    PartPrice = 42.60,
                    CategoryID = 16
               },
               new Parts
               {
                    PartID = 17,
                    PartBrand = "Diety",
                    PartModel = "Clinch",
                    Description = "34.9", 
                    ImagePath="diety.png",
                    PartPrice = 6.99,
                    CategoryID = 17
               },
               new Parts
               {
                    PartID = 18,
                    PartBrand = "Fox",
                    PartModel = "RP23",
                    Description = "Air shock, 190 mm, travel 50 mm", 
                    ImagePath="rp23.png",
                    PartPrice = 137.11,
                    CategoryID = 18
               },
               new Parts
               {
                    PartID = 19,
                    PartBrand = "NSK",
                    PartModel = "6902",
                    Description = "37-24-10", 
                    ImagePath="nsk.png",
                    PartPrice = 1.72,
                    CategoryID = 19
               },
               new Parts
               {
                    PartID = 20,
                    PartBrand = "KMC",
                    PartModel = "K710",
                    Description = "Chain or singlespeed, 114 links", 
                    ImagePath="kmc.png",
                    PartPrice = 18.19,
                    CategoryID = 20
               },
               new Parts
               {
                    PartID = 21,
                    PartBrand = "Garbaruk",
                    PartModel = "Oval",
                    Description = "Oval chainring, 24T, 104BCD", 
                    ImagePath="garbaruk.png",
                    PartPrice = 34.01,
                    CategoryID = 21
               },
               new Parts
               {
                    PartID = 22,
                    PartBrand = "Sram",
                    PartModel = "PG971",
                    Description = "11-28", 
                    ImagePath="pg971.png",
                    PartPrice = 15.99,
                    CategoryID = 22
               },
               new Parts
               {
                    PartID = 23,
                    PartBrand = "Nukeproof",
                    PartModel = "Ti",
                    Description = "2.25, 650", 
                    ImagePath="nukeproof.png",
                    PartPrice = 140.02,
                    CategoryID = 23
               },
               new Parts
                {
                    PartID = 24,
                    PartBrand = "MutantBikes",
                    PartModel = "24 Evo",
                    Description = "24, 110/15, integrated 1.1/8, 25.4, spanish bb", 
                    ImagePath="24evo.png",
                    PartPrice = 250.55,
                    CategoryID = 1
               },
               new Parts
                {
                    PartID = 25,
                    PartBrand = "Manitou",
                    PartModel = "Circus",
                    Description = "26, travel 80-1300 mm, 20mm axel, 1.1/8", 
                    ImagePath="circus.png",
                    PartPrice = 234.33,
                    CategoryID = 2
               },
               new Parts
                {
                    PartID = 26,
                    PartBrand = "Specialized",
                    PartModel = "Phenom",
                    Description = "steel rails", 
                    ImagePath="phenom.png",
                    PartPrice = 50.03,
                    CategoryID = 3
               },
               new Parts
                {
                    PartID = 27,
                    PartBrand = "Lapier",
                    PartModel = "XC",
                    Description = "31.6, 350 mm", 
                    ImagePath="lapiere.png",
                    PartPrice = 14.10,
                    CategoryID = 4
               },
               new Parts
                {
                    PartID = 28,
                    PartBrand = "Specialized",
                    PartModel = "DJ",
                    Description = "32 mm, 31.8", 
                    ImagePath="specializedj.png",
                    PartPrice = 10.04,
                    CategoryID = 5
               },
               new Parts
                {
                    PartID = 29,
                    PartBrand = "Funn",
                    PartModel = "FlatOut",
                    Description = "31.8, 750mm", 
                    ImagePath="flatout.png",
                    PartPrice = 27.80,
                    CategoryID = 6
               },
               new Parts
                {
                    PartID = 30,
                    PartBrand = "SunRims",
                    PartModel = "DoubleWide",
                    Description = "39 mm, 26 inches, 36 spokes", 
                    ImagePath="doublewide.png",
                    PartPrice = 70.55,
                    CategoryID = 7
               },
               new Parts
                {
                    PartID = 31,
                    PartBrand = "Novatek",
                    PartModel = "DS1451",
                    Description = "9 mm axel, 135 width, 32 spokes, cassete driver", 
                    ImagePath="novatek.png",
                    PartPrice = 51.40,
                    CategoryID = 1
               },
               new Parts
                {
                    PartID = 32,
                    PartBrand = "Kenda",
                    PartModel = "SmallBlock8",
                    Description = "2.2, 26 inches, steel", 
                    ImagePath="kendasb8.png",
                    PartPrice = 22.39,
                    CategoryID = 9
               },
               new Parts
                {
                    PartID = 33,
                    PartBrand = "CST",
                    PartModel = "Slim",
                    Description = "1.5 - 1.75", 
                    ImagePath="cst.png",
                    PartPrice = 2.75,
                    CategoryID = 10
               },
               new Parts
               {
                    PartID = 34,
                    PartBrand = "Shimano",
                    PartModel = "Saint",
                    Description = "front and rear, 1000 mm and 1700 mm", 
                    ImagePath="saint.png",
                    PartPrice = 260.10,
                    CategoryID = 11
               },
               new Parts
               {
                    PartID = 35,
                    PartBrand = "ColtBikes",
                    PartModel = "Rifle",
                    Description = "green, double lock", 
                    ImagePath="coltrifle.png",
                    PartPrice = 9.30,
                    CategoryID = 12
               },
               new Parts
               {
                    PartID = 36,
                    PartBrand = "Mach",
                    PartModel = "Top",
                    Description = "2.2 - 1.6 - 2.2", 
                    ImagePath="mach.png",
                    PartPrice = 0.35,
                    CategoryID = 13
               },
               new Parts
                {
                    PartID = 37,
                    PartBrand = "Tektro",
                    PartModel = "Wave",
                    Description = "160 mm", 
                    ImagePath="wave.png",
                    PartPrice = 7.95,
                    CategoryID = 14               
               },
               new Parts
               {
                    PartID = 38,
                    PartBrand = "Cult",
                    PartModel = "ProPegs",
                    Description = "two alu pegs", 
                    ImagePath="propegs.png",
                    PartPrice = 12.77,
                    CategoryID = 15
               },
               new Parts
               {
                    PartID = 39,
                    PartBrand = "FSA",
                    PartModel = "BigPig DH",
                    Description = "1.5", 
                    ImagePath="bigpig.png",
                    PartPrice = 60.15,
                    CategoryID = 16
               },
               new Parts
               {
                    PartID = 40,
                    PartBrand = "ChinHyiang",
                    PartModel = "Yako",
                    Description = "34.9", 
                    ImagePath="china.png",
                    PartPrice = 1.79,
                    CategoryID = 17
               },
               new Parts
               {
                    PartID = 41,
                    PartBrand = "RS",
                    PartModel = "Monarch",
                    Description = "Air shock, 216 mm, travel 57 mm", 
                    ImagePath="monarch.png",
                    PartPrice = 241.42,
                    CategoryID = 18
               },
               new Parts
               {
                    PartID = 42,
                    PartBrand = "SKF",
                    PartModel = "6805",
                    Description = "22-10-7", 
                    ImagePath="skf.png",
                    PartPrice = 0.91,
                    CategoryID = 19
               },
               new Parts
               {
                    PartID = 43,
                    PartBrand = "Sram",
                    PartModel = "pg950",
                    Description = "Chain or multispeed (9sp), 118 links", 
                    ImagePath="pg951.png",
                    PartPrice = 12.26,
                    CategoryID = 20
               },
               new Parts
               {
                    PartID = 44,
                    PartBrand = "Driveline",
                    PartModel = "Circle",
                    Description = "Circle NW chainring, 32T, 104BCD", 
                    ImagePath="driveline.png",
                    PartPrice = 23.09,
                    CategoryID = 21
               },
               new Parts
               {
                    PartID = 45,
                    PartBrand = "Shimano",
                    PartModel = "XT",
                    Description = "12-26", 
                    ImagePath="xt.png",
                    PartPrice = 31.11,
                    CategoryID = 22
               },
               new Parts
               {
                    PartID = 46,
                    PartBrand = "Fox",
                    PartModel = "Steel",
                    Description = "2.75, 350", 
                    ImagePath="foxspring.png",
                    PartPrice = 16.26,
                    CategoryID = 23
               }               
            };

            return parts;
        }
    }
}