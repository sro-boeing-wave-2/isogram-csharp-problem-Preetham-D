using System;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class UnitTest1
    {
 
        [Fact]
        public void emptyString()
        {
            Assert.True(Class1.isIsogram(""));
        }
        [Fact]
        public void lowerCaseIsogram()
        {
            Assert.True(Class1.isIsogram("isogram"));
        }
        [Fact]
        public void lowerCaseEleven()
        {
            Assert.False(Class1.isIsogram("eleven"));
        }
        [Fact]
        public void longEnglishWord()
        {
            Assert.True(Class1.isIsogram("subdermatoglyphic"));
        }
        [Fact]
        public void mixedCaseDuplicated()
        {
            Assert.True(Class1.isIsogram("Alphabet"));
        }
        [Fact]
        public void withHyphen()
        {
            Assert.True(Class1.isIsogram("thumbscrew-japingly"));
        }
        [Fact]
        public void withDuplicatedHyphen()
        {
            Assert.True(Class1.isIsogram("six-year-old"));
        }
        [Fact]
        public void nameWithSpaces()
        {
            Assert.True(Class1.isIsogram("PREeTHAM"));
        }
    }
}
