using KittyTask;

namespace Tests
{
    public class Tests
    {
        private KittyTask1 _kittyTask1;
        private KittyTask2 _kittyTask2;
        private KittyTask3 _kittyTask3;
        private KittyTask4 _kittyTask4;
        private KittyTask5 _kittyTask5;
        private KittyTask6 _kittyTask6;
        private KittyTask7 _kittyTask7;
        private KittyTask8 _kittyTask8;

        [SetUp]
        public void Setup()
        {
            _kittyTask1 = new KittyTask1();
            _kittyTask2 = new KittyTask2();
            _kittyTask3 = new KittyTask3();
            _kittyTask4 = new KittyTask4();
            _kittyTask5 = new KittyTask5();
            _kittyTask6 = new KittyTask6();
            _kittyTask7 = new KittyTask7();
            _kittyTask8 = new KittyTask8();
        }

        [TestCase(0, 0)]
        [TestCase(1, 60)]
        [TestCase(2, 120)]
        [TestCase(3, 180)]
        public void KittyTask1_Test(int minutes, int expectedOutput)
        {
            var result = _kittyTask1.Invoke(minutes);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(0, 0, 0)]
        [TestCase(-10, 5, -5)]
        [TestCase(123, 321, 444)]
        [TestCase(-100, -100, -200)]
        public void KittyTask2_Test(int a, int b, int expectedOutput)
        {
            var result = _kittyTask2.Invoke(a, b);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(0, 0, true)]
        [TestCase(0, 1, false)]
        public void KittyTask3_Test(int a, int b, bool expectedOutput)
        {
            var result = _kittyTask3.Invoke(a, b);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(3, 2, 3)]
        [TestCase(7, 4, 14)]
        [TestCase(10, 10, 50)]
        public void KittyTask4_Test(int a, int b, int expectedOutput)
        {
            var result = _kittyTask4.Invoke(a, b);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(17, false)]
        [TestCase(18, true)]
        [TestCase(19, true)]
        [TestCase(32, true)]
        [TestCase(33, true)]
        [TestCase(34, false)]
        public void KittyTask5_Test(int age, bool expectedOutput)
        {
            var result = _kittyTask5.Invoke(age);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase("", "", " ")]
        [TestCase("meow", "nya", "meow nya")]
        public void KittyTask6_Test(string string1, string string2, string expectedOutput)
        {
            var result = _kittyTask6.Invoke(string1, string2);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(2, 3, 5, 36)]
        [TestCase(1, 2, 3, 22)]
        [TestCase(5, 2, 8, 50)]
        [TestCase(-1, -1, -1, 0)]
       
        public void KittyTask7_Test(int chickenCount, int cowCount, int pigCount, int expectedOutput)
        {
            var result = _kittyTask7.Invoke(chickenCount, cowCount, pigCount);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        [TestCase(0, 0)]
        [TestCase(-1, 1)]
        [TestCase(1, 1)]
        public void KittyTask8_Test(int number, int expectedOutput)
        {
            var result = _kittyTask8.Invoke(number);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}