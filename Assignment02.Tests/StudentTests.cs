using System;
using Xunit;
using ImmutableStudent;


namespace Student.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Student_toString()
        {
            //Given
            var teststudent = new Student(1234, "Jens", "Jensen", new DateTime(2021, 6, 13), new DateTime(2022, 4, 9), new DateTime(2021, 12, 25)); ;

            //When
            var expectedstring = "Student id: 1234, \nStudent name: Jens Jensen. \nStatus: Active \nStart and end date: 13/06/2021 : 09/04/2022. \nGraduation date: 25/12/2021. ".Trim();
            var actualstring = teststudent.ToString().Trim();

            //Then
            Assert.Equal(expectedstring, actualstring);
        }
    }
}
