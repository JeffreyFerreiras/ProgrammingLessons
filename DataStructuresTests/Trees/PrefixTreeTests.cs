using DataStructures.Trees;
using NUnit.Framework;

namespace DataStructuresTests.Trees
{
    [TestFixture]
    public class PrefixTreeTests
    {
        static readonly string[] memoryDictionary =
            {
                "test",
                "try",
                "angle",
                "the",
                "people",
                "things",
                "these",
                "terra",
                "ark"
            };


        [Theory]
        [TestCase("Not In Dictionary", new string[] { })]
        [TestCase("te", new string[] { "test", "terra" })]
        [TestCase("th", new string[] { "things", "these", "the" })]
        [TestCase("tr", new string[] { "try" })]
        [TestCase("a", new string[] { "ark", "angle" })]
        [TestCase("", new string[] {
                "test",
                "try",
                "angle",
                "the",
                "people",
                "things",
                "these",
                "terra",
                "ark"
            })]

        public void SearchReturnsAllAvailableSubset(string searchString, string[] expected)
        {
            var trie = new PrefixTree();

            foreach (string word in memoryDictionary)
            {
                trie.Add(word);
            }

            var results = trie.Search(searchString);

            Assert.That(results.Except(expected).Any(), Is.False);
            Assert.That(expected.Except(results).Any(), Is.False);
        }
    }
}
