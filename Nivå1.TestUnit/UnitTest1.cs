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
        [TestCase("David", 21, "#22,David")]
        [TestCase("Josef", 30, "#31,Josef")]

        public void OperatorOverloadTest_Pluss(string name, int number, string expectedNumber) 
        {
            List<Team> testlist = new()
            {
                new Player(name, number),
             };
            testlist[0]++;

            Assert.That(testlist[0].ToString(), Is.EqualTo(expectedNumber));
        }


        [TestCase("Arne", 25, "#25,Arne")]
        [TestCase("Josef", 21, "#21,Josef")]

        public void OperatorOverloadTest_EqualsTrue(string name, int number, string expectedNumber)
        {

            List<Team> testlist = new()
            {
                new Player(name, number),
             };
            bool checker = testlist[0].ToString() == expectedNumber;


            Assert.That(checker is true);
        }

        [TestCase("Arne", 25, "#222,Arne")]
        [TestCase("Abdie", 21, "#222,Arne")]

        public void OperatorOverloadTest_EqualsFalse(string name, int number, string expectedNumber)
        {

            List<Team> testlist = new()
            {
                new Player(name, number),
             };
            bool checker1 = testlist[0].ToString() != expectedNumber;

            Assert.That(checker1 is true);
        }

    }
}