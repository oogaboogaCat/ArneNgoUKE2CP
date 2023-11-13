using ArneNgoNivå1;

namespace Nivå1.TestUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase("Iman", 23, "DangerousClassmate", "#23,Iman, A Star Player! Description: DangerousClassmate")]
        [TestCase("Arne",25, "DangerousCoder", "#25,Arne, A Star Player! Description: DangerousCoder")]
        public void StarPlayerTest(string name,int number,string star, string expected)
        {
            Star actual = new(name,number,star);

            Assert.That(actual.ToString(), Is.EqualTo(expected));
        }

        [TestCase("Tomas",200,"#200,Tomas")]
        [TestCase("Agustina", 100,"#100,Agustina")]
        [TestCase("Reza", 420, "#420,Reza")]

        public void NormalPlayerTest(string name,int number, string expected) 
        {
            Player actual = new(name, number);

            Assert.That(actual.ToString(), Is.EqualTo(expected));
        }
        [TestCase("Arne",25,"#26,Arne")]
        public void OperatorOverloadTest(string name, int number, string expectedNumber) 
        {
            List<Team> testlist = new()
            {
                new Player(name, number),
             };
            testlist[0]++;

            Assert.That(testlist[0].ToString(), Is.EqualTo(expectedNumber));


        }

    }
}