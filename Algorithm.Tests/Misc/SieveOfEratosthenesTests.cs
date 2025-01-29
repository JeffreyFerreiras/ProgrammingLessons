using NUnit.Framework;
using Algorithms.Misc;

namespace Algorithms.Tests.Misc;

internal class SieveOfEratosthenesTests
{
    [Test]
    public void FindPrimesUpTo_ValidPrimeNumber_FindsAllPrimesUptoTheProvidedNumber()
    {
        // arrange
        int primesLimit = 30;

        // act
        var result = SieveOfEratosthenes.FindPrimesUpTo(primesLimit);

        using (Assert.EnterMultipleScope())
        {
            // assert
            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result[1], Is.EqualTo(3));
            Assert.That(result[2], Is.EqualTo(5));
            Assert.That(result[3], Is.EqualTo(7));
            Assert.That(result[4], Is.EqualTo(11));
            Assert.That(result[5], Is.EqualTo(13));
            Assert.That(result[6], Is.EqualTo(17));
            Assert.That(result[7], Is.EqualTo(19));
            Assert.That(result[8], Is.EqualTo(23));
            Assert.That(result[9], Is.EqualTo(29));
        }
    }
}
