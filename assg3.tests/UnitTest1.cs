using System;
using Xunit;
using csharp_assignment3;
using finale;

namespace assg3.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
             Maths m1=new Maths(20);
            //Act
             float per1=m1.calculate_perimeter(20);
            //Assert
            Assert.IsType<float>(per1);
            Assert.Equal(80,per1);
            Assert.NotEqual(75,per1);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
             Maths m1=new Maths(20,15);
            //Act
             float per2=m1.calculate_perimeter(20,15);
            //Assert
            Assert.IsType<float>(per2);
            Assert.Equal(70,per2);
            Assert.NotEqual(75,per2);
        }
        [Fact]
        public void Test3()
        {
            //Arrange
             Maths m1=new Maths(20,15,10);
            //Act
             float per3=m1.calculate_perimeter(20,15,10);
            //Assert
            Assert.IsType<float>(per3);
            Assert.Equal(45,per3);
            Assert.NotEqual(75,per3);
        }
    }
}
