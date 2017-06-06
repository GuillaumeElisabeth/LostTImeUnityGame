﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using System.Runtime.Serialization.Json;

using System.IO;
using SimpleJSON;

using Newtonsoft.Json;

namespace LostTimeGame.Tests.QuestSystemTests.JsonParser
{
    [TestFixture]
    class QuestJsonParserTests
    {
        [Test]
        public void Read_JSON_file()
        {
            Quest quest1 = JsonConvert.DeserializeObject<Quest>(File.ReadAllText(@"..\..\QuestSystemTests\JsonParser\QuestTest.json"));

            using (StreamReader file = File.OpenText(@"..\..\QuestSystemTests\JsonParser\QuestTest.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Quest quest2 = (Quest)serializer.Deserialize(file, typeof(Quest));
            }

            //Theoretical test
            /*string[] n = System.IO.File.ReadAllLines(@"..\..\QuestSystemTests\JsonParser\QuestTest.json");
            Console.WriteLine(n);

            string[] o = System.IO.File.ReadAllLines(@"..\..\QuestSystemTests\JsonParser\QuestTest1.json");
            Console.WriteLine(o);*/
        }
    }
}