using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Students_Tests;

namespace StudentsTest
{
    public interface ISubject
    {
        double AvgBal();
        string SubjectName { get; set; }

    }

    public class Student
    {

        public double Rating(ISubject _object)
        {
            switch (_object.SubjectName)
            {
                case "Programming":
                    return _object.AvgBal() * 10;
                    break;
                case "Administration":
                    return _object.AvgBal() * 5;
                    break;
                default:
                    return 0;

            }


        }

    }
    public class Class1
    {
        [Fact]
        public void TestRating()
        {
            Mock<ISubject> mock = new Mock<ISubject>();
            mock.Setup(f => f.AvgBal()).Returns(4);
            mock.Setup(f => f.SubjectName).Returns("Programming");
            Student s = new Student();
            double r = s.Rating(mock.Object);
            Assert.Equal(40, r);
        }

    }
}
