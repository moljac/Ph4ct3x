using System;
using System.IO;
using Xunit;

namespace UnitTests.HolisticWare.Ph4ct3x.Sports.Judo.XUnit
{
    public class UnitTest1
    {
        global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data data = null;

        [InlineData("cvjetko")]
        [InlineData("cvjetko lara")]
        [InlineData("kristo")]
        [InlineData("oberan")]
        [InlineData("croatia")]
        [InlineData("island")]
        [Theory]
        public void TestData_Search_General_01(string search)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchGeneral(search).Result;

            File.WriteAllText($"./ijf_data_general_01_{search}.json", result);

            return;
        }

        [InlineData("croatia")]
        [InlineData("island")]
        [Theory]
        public void TestData_Search_Country_01(string search)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCountry(search).Result;

            File.WriteAllText($"./ijf_data_country_01_{search}.json", result);

            return;
        }

        [InlineData(2019, 06, null)]
        [InlineData(2019, 06, "")]
        [Theory]
        public void TestData_Search_Competition_01(int year, int month, string rank)
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCompetition(year, month, rank).Result;

            File.WriteAllText($"./ijf_data_competition_01_{year}{month}-{rank}.json", result);

            return;
        }

        [Fact]
        public void TestData_Search_Competition_Ranks()
        {

            data = new global::HolisticWare.Ph4ct3x.Sports.Judo.InternationalJudoFederation.Data();

            string result = null;

            result = data.GetDataSearchCompetitionRanks().Result;

            File.WriteAllText($"./ijf_data_competition_ranks.json", result);

            return;
        }
    }
}
