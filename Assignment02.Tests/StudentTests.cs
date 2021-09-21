using System;
using Xunit;


namespace Student.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_two_identical_student_confirm_not_equal()
        {
            //Given
            var student1 = new Student(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
            var student2 = new Student(190, "Georg", "Jum", DateTime.Today, DateTime.Today.AddDays(20), DateTime.Today.AddDays(10));
            //When

            //Then
            Assert.NotEqual(student2, student1);
        }
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

        [Fact]
        public void Student_is_active()
        {
            //Given
            var student = new Student(1234, "Jens", "Jensen", DateTime.Today.AddDays(-100), DateTime.Today.AddDays(200), DateTime.Today.AddDays(95));

            //When
            var expectedStatus = Student.ActivityStatus.Active;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }

        [Fact]
        public void Student_is_dropout()
        {

            //Given
            var student = new Student(3333, "Bob", "Bobsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(40));
            //When
            var expectedStatus = Student.ActivityStatus.Dropout;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
        [Fact]
        public void Student_is_new()
        {
            //Given
            Student student = new Student(444, "Alice", "Alicen", DateTime.Today.AddDays(-5), DateTime.Today.AddDays(100), DateTime.Today.AddDays(40));

            //When
            var expectedStatus = Student.ActivityStatus.New;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
        [Fact]
        public void Student_is_graduated()
        {
            //Given
            Student student = new Student(5555, "Lars", "Larsen", DateTime.Today.AddDays(-100), DateTime.Today, DateTime.Today.AddDays(-5));

            //When
            var expectedStatus = Student.ActivityStatus.Graduated;
            var actualStatus = student.Status;

            //then
            Assert.Equal(expectedStatus, actualStatus);
        }
    }
}
