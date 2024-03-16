namespace Rational.Tests
{
    [TestFixture]
    public class Tests
    {

        private Rationaldigit _firstRational { get; set; } = null!;
        private Rationaldigit _secondRational { get; set; } = null!;


        [SetUp]
        public void Setup()
        {
            _firstRational = new Rationaldigit(2, 3);
            _secondRational = new Rationaldigit(4, 5);
        }

        [TestCase(2, 3, 4, 5)]
        public void Test1(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational + _secondRational;
            //assert
            Assert.That(actual.ToString, Is.EqualTo("22/15"));
        }

        [TestCase(2, 3, 4, 5)]
        public void Test2(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational - _secondRational;
            //assert
            Assert.That(actual.ToString, Is.EqualTo("-2/15"));
        }

        [TestCase(2, 3, 4, 5)]
        public void Test3(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational * _secondRational;
            //assert
            Assert.That(actual.ToString, Is.EqualTo("8/15"));
        }

        [TestCase(1, 3, 1, 10)]
        public void Test4(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational / _secondRational;
            //assert
            Assert.That(actual.ToString, Is.EqualTo("10/3"));
        }

        [TestCase(2, 1, 4, 5)]
        public void Test5(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational == _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [TestCase(2, 1, 4, 5)]
        public void Test6(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational != _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }


        [TestCase(2, 1, 4, 5)]
        public void Test7(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational > _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }

        [TestCase(2, 1, 4, 5)]
        public void Test8(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational < _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [TestCase(2, 1, 2, 1)]
        public void Test9(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational >= _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }

        [TestCase(2, 1, 4, 5)]
        public void Test10(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational <= _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [TestCase(2, 1)]
        public void Test11(int first_a, int first_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            var actual = -_firstRational;
            Assert.That(actual.Numerator, Is.EqualTo(-2));
        }


        [TestCase(-2, -1)]
        public void Test12(int first_a, int first_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            var actual = -_firstRational;
            Assert.That(actual.Numerator, Is.EqualTo(-2));
        }

        [TestCase(2, 2, 2, 2)]
        public void Test13(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational + _secondRational;
            Assert.That(actual.ToString, Is.EqualTo("2"));
        }

        [TestCase(8, 2)]
        public void Test13(int first_a, int first_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            var actual = _firstRational;
            Assert.That(actual.ToString, Is.EqualTo("4"));
        }

        [TestCase(2, 8)]
        public void Test14(int first_a, int first_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            var actual = _firstRational;
            Assert.That(actual.ToString, Is.EqualTo("1/4"));
        }

        [TestCase(2, 1, 4, 5)]
        public void Test15(int first_a, int first_b, int second_a, int seconf_b)
        {
            _firstRational = new Rationaldigit(first_a, first_b);
            _secondRational = new Rationaldigit(second_a, seconf_b);
            var actual = _firstRational <= _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }
    }
}