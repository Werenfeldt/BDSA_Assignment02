using System;
using Xunit;

namespace ImmutableStudent.Tests
{
    public class UnitTest1 {
        [Fact]
        public void Given_two_identical_student_confirm_identical()
        {
        //Given
        var student1 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
        var student2 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
        //When
        
        //Then
        Assert.Equal(true, student2 == student1);
        }
        [Fact]
        public void ToString_works()
        {
        //Given
        var student1 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
        //When
        string teststr = "Student id: 190, \nStudent name: Georg Jum. \nStatus: " + student1._status + " \nStart and end date: " + student1._startDate.ToString("d") +" : " + student1._endDate.ToString("d") + ". \n" + "Graduation date: " + student1._graduationDate.ToString("d")+". \n";
        //Then
        Assert.Equal(teststr, student1.ToString());
        }
    }
}