using System;
using Xunit;


namespace StudentClass.Tests
{
    public class UnitTest1
    {
        // [Fact]
        // public void StudentStatus_is_only_readable()
        // {
        //     //setup
        //     var teststudent = new Student(1234, "Jens", "Jensen", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(200), DateTime.Today.AddDays(95));
        //     var oldstatus = teststudent.getstatus();

        //     //act
        //     teststudent.changestatus();
        //     var newstatus = teststudent.getstatus();

        //     //test
        //     Assert.Equal(oldstatus, newstatus);
        // }

        // [Fact]
        // public void Student_id_not_editable()
        // {
        //     //Given
        //     var teststudent = new Student();
        //     int oldID = teststudent.getID();

        //     //When
        //     teststudent.setID();
        //     int newID = teststudent.getID();

        //     //Then
        //     Assert.Equal(oldID, newID);
        //}

        [Fact]
        public void Student_toString()
        {
            //Given
            var teststudent = new Student(1234, "Jens", "Jensen", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(200), DateTime.Today.AddDays(95)); ;

            //When
            var expectedstring = "Student id: 1234, \nStudent name: Jens Jensen. \nStatus: Active \nStart and end date: 06/13/2021 : 04/09/2022. \nGraduation date: 25/12/2021. ".Trim();
            var actualstring = teststudent.ToString().Trim();

            //Then
            Assert.Equal(expectedstring, actualstring);
        }
    }
}
