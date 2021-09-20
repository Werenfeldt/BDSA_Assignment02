using System;
using Xunit;

namespace Student.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void StudentStatus_is_only_readable()
        {
            //setup
            var teststudent = new Student();
            var oldstatus = teststudent.getstatus();

            //act
            teststudent.changestatus();
            var newstatus = teststudent.getstatus();

            //test
            Assert.Equal(oldstatus, newstatus);
        }

        [Fact]
        public void Student_id_not_editable()
        {
        //Given
        var teststudent = new Student();
        int oldID = teststudent.getID();

        //When
        teststudent.setID();
        int newID = teststudent.getID();

        //Then
        Assert.Equal(oldID, newID);
        }

        [Fact]
        public void Student_toString()
        {
        //Given
        var teststudent = new Student();
        
        //When
        var expectedstring = "";
        var actualstring = teststudent.toString();
        
        //Then
        Assert.Equal(expectedstring, actualstring);
        }
    }
}
