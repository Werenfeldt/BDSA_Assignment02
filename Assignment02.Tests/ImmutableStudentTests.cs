using System;
using Xunit;

namespace ImmutableStudent.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_two_identical_student_confirm_identical()
        {
            //Given
            var student1 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
            var student2 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
            //When

            //Then
            Assert.Equal(student2, student1);
        }
        [Fact]
        public void ToString_works()
        {
            //Given
            var student1 = new ImmutableStudent(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
            //When
            string teststr = "Student id: 190, \nStudent name: Georg Jum. \nStatus: " + student1.Status + " \nStart and end date: " + student1.StartDate.ToString("d") + " : " + student1.EndDate.ToString("d") + ". \n" + "Graduation date: " + student1.GraduationDate.ToString("d") + ". \n";
            //Then
            Assert.Equal(teststr, student1.ToString());
        }


        [Fact]
        public void Student_is_active()
        {
            //Given
            var student = new ImmutableStudent(1234, "Jens", "Jensen", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(200), DateTime.Today.AddDays(95));

            //When
            var expectedStatus = ImmutableStudent.ActivityStatus.Active;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void Student_is_dropout()
        {

            //Given
            var student = new ImmutableStudent(3333, "Bob", "Bobsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(40));
            //When
            var expectedStatus = ImmutableStudent.ActivityStatus.Dropout;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
        [Fact]
        public void Student_is_new()
        {
            //Given
            var student = new ImmutableStudent(444, "Alice", "Alicen", DateTime.Today.AddDays(-5), DateTime.Today.AddDays(100), DateTime.Today.AddDays(40));

            //When
            var expectedStatus = ImmutableStudent.ActivityStatus.New;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
        [Fact]
        public void Student_is_graduated()
        {
            //Given
            var student = new ImmutableStudent(5555, "Lars", "Larsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(-5));

            //When
            var expectedStatus = ImmutableStudent.ActivityStatus.Graduated;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
    }
}