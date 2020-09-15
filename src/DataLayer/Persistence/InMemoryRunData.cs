using System;
using System.Collections.Generic;
using System.Linq;
using RunIt.Application.Common.Interfaces;
using RunIt.Domain.Common;
using RunIt.Domain.ValueObjects;
using RunIt.Runs.Entities;

namespace RunIt.DataLayer.Persistence
{
    public class InMemoryRunData : IRunData
    {
        private List<Run> runs;

        public InMemoryRunData()
        {
            runs = new List<Run>()
            {
                new Run
                {
                    Date = new DateTime(2020, 3, 26),
                    Distance = RunDistance.Create(7.36).Value,
                    Type = RunType.Trail,
                    RunTemperature = new RunTemperature(5),
                    RunWindSpeed = RunWindSpeed.Create(9).Value,
                    Clothes = new Clothes("thin sweater, tight sweater, tight shirt, shorts"),
                    Gear = new Gear(WaterSupply.Create(4.0).Value, new FoodBag
                    {
                        Items = new List<FoodItem>
                        {
                            new FoodItem("guu", 2),
                            new FoodItem("peanut butter sandwich", 1)
                        }
                    }),
                    SatisfactionLevel = SatisfactionLevel.Medium,
                    Notes = new Notes("Great run!")
                },
                new Run
                {
                    Date = new DateTime(2020, 4, 6),
                    Distance = RunDistance.Create(8.36).Value,
                    Type = RunType.Road,
                    RunTemperature = new RunTemperature(13),
                    RunWindSpeed = RunWindSpeed.Create(16).Value,
                    Clothes = new Clothes("tight shirt, shorts"),
                    Gear = new Gear(WaterSupply.Create(2.0).Value, new FoodBag
                    {
                        Items = new List<FoodItem>
                        {
                            new FoodItem("guu", 2),
                            new FoodItem("peanut butter sandwich", 1)
                        }
                    }),
                    SatisfactionLevel = SatisfactionLevel.Hard,
                    Notes = new Notes("Ok run!")
                },
                new Run
                {
                    Date = new DateTime(2020, 5, 6),
                    Distance = RunDistance.Create(8.36).Value,
                    Type = RunType.Road,
                    RunTemperature = new RunTemperature(13),
                    RunWindSpeed = RunWindSpeed.Create(16).Value,
                    Clothes = new Clothes("tight shirt, shorts"),
                    Gear = new Gear(WaterSupply.Create(2.0).Value, new FoodBag
                    {
                        Items = new List<FoodItem>
                        {
                            new FoodItem("guu", 2),
                            new FoodItem("peanut butter sandwich", 1)
                        }
                    }),
                    SatisfactionLevel = SatisfactionLevel.Hard,
                    Notes = new Notes("Horrible run")
                }
            };

        }
        public IEnumerable<Run> GetAll()
        {
            return from r in runs
                orderby r.Date
                select r;
        }
    }
}