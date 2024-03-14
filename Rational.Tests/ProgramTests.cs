namespace Rational.Tests
{
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

        [Test]
        public void Test1()
        {
            var actual = _firstRational + _secondRational;
            //assert
            Assert.That(22, Is.EqualTo(actual.Numerator));
            Assert.That(15, Is.EqualTo(actual.Denominator));
        }

        [Test]
        public void Test2()
        {
            var actual = _firstRational - _secondRational;
            //assert
            Assert.That(-2, Is.EqualTo(actual.Numerator));
            Assert.That(15, Is.EqualTo(actual.Denominator));
        }

        [Test]
        public void Test3()
        {
            var actual = _firstRational * _secondRational;
            //assert
            Assert.That(8, Is.EqualTo(actual.Numerator));
            Assert.That(15, Is.EqualTo(actual.Denominator));
        }

        [Test]
        public void Test4()
        {
            var actual = _firstRational / _secondRational;
            //assert
            Assert.That(10, Is.EqualTo(actual.Numerator));
            Assert.That(12, Is.EqualTo(actual.Denominator));
        }

        [Test]
        public void Test5()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(4, 5);
            var actual = _firstRational == _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Test6()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(4, 5);
            var actual = _firstRational != _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Test7()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(4, 5);
            var actual = _firstRational > _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Test8()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(4, 5);
            var actual = _firstRational < _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Test9()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(2, 1);
            var actual = _firstRational >= _secondRational;
            Assert.That(actual, Is.EqualTo(true));
        }

        [Test]
        public void Test10()
        {
            _firstRational = new Rationaldigit(2, 1);
            _secondRational = new Rationaldigit(4, 5);
            var actual = _firstRational <= _secondRational;
            Assert.That(actual, Is.EqualTo(false));
        }

        [Test]
        public void Test11()
        {
            _firstRational = new Rationaldigit(2, 1);
            var actual = -_firstRational;
            Assert.That(actual.Numerator, Is.EqualTo(-2));
        }

        [Test]
        public void Test15()
        {
            _firstRational = new Rationaldigit(-2, -1);
            var actual = -_firstRational;
            Assert.That(actual.Numerator, Is.EqualTo(-2));
        }

        [Test]
        public void Test12()
        {
            _firstRational = new Rationaldigit(2, 2);
            _secondRational = new Rationaldigit(2, 2);
            var actual = _firstRational + _secondRational;
            Assert.That(actual.ToString, Is.EqualTo("2"));
        }

        [Test]
        public void Test13()
        {
            _firstRational = new Rationaldigit(8, 2);
            var actual = _firstRational;
            Assert.That(actual.ToString, Is.EqualTo("4"));
        }

        [Test]
        public void Test14()
        {
            _firstRational = new Rationaldigit(2, 8);
            var actual = _firstRational;
            Assert.That(actual.ToString, Is.EqualTo("1/4"));
        }
    }
}