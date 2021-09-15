using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit;

namespace CrushKillDestroy
{
    public class UnitTest1
    {
        [Fact]
        public void TwoStringsTest()
        {
            Class1 obj = new Class1();
            int length;
            string[] strings = {"Hello", "World"};
            // arrange


            // act
            length = obj.StringLenghts(strings);
            // assert
            Assert.Equal(5 + 5, length);
        }

        [Fact]
        public void EmptyArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = { };

            int length = obj.StringLenghts(strings);

            Assert.Equal(0, length);


        }

        [Fact]
        public void NullArrayTest()
        {
            Class1 obj = new Class1();
            string[] strings = null;

            int length = obj.StringLenghts(strings);

            Assert.Equal(0, length);
        }

        [Fact]
        public void ArrayWithNullTest()
        {
            Class1 obj = new Class1();
            string[] strings = {"Hello", null, "World"};

            int length = obj.StringLenghts(strings);

            Assert.Equal(5+5, length);
        }

            
    }
}
