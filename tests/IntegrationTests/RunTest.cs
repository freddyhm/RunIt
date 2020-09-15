using System;
using System.Collections.Generic;
using FluentAssertions;
using RunIt.Domain.Common;
using RunIt.Domain.ValueObjects;
using RunIt.Runs.Entities;
using Xunit;

namespace RunIt.IntegrationTests
{
    //public class RunTest
    //{
    //    [Fact]
    //        public void GivenValidRun_Return
    //        //public void ShouldReturnRunWithRequestValues()
    //        {
    //            var run = new Run
    //            {
    //                Date = new DateTime(2020, 3, 26),
    //                Distance = RunDistance.Create(7.36).Value,
    //                Type = RunType.Trail,
    //                RunTemperature = new RunTemperature(5),
    //                RunWindSpeed = RunWindSpeed.Create(9).Value,
    //                Clothes = new Clothes("thin sweater, tight sweater, tight shirt, shorts"),
    //                Gear = new Gear(WaterSupply.Create(4.0).Value, new FoodBag
    //                {
    //                    Items = new List<FoodItem>
    //                    {
    //                        new FoodItem("guu", 2),
    //                        new FoodItem("peanut butter sandwich", 1)
    //                    }
    //}),
    //                SatisfactionLevel = SatisfactionLevel.Medium,
    //                Notes = new Notes("Great run!")
    //            };

    //            var processor = new RunProcessor();
    //Run result = processor.AddRun(run);

    //result.Should().NotBeNull();

    //run.Date.Should().Be(result.Date);
    //run.Distance.Should().Be(result.Distance);
    //run.Type.Should().Be(result.Type);
    //run.RunTemperature.Should().Be(result.RunTemperature);
    //run.RunWindSpeed.Should().Be(result.RunWindSpeed);
    //run.Clothes.Should().Be(result.Clothes);
    //run.Gear.Should().Be(result.Gear);
    //run.SatisfactionLevel.Should().Be(result.SatisfactionLevel);
    //run.Notes.Should().Be(result.Notes);
    //        }
    //}
}
