using System;

namespace StudentClass
{
    public class Student
    {
        public int _id { get; init; }
        string _givenName, _surName;
        DateTime _startDate, _endDate, _graduationDate;
        readonly ActivityStatus _status;
        public enum ActivityStatus
        {
            New,
            Active,
            Dropout,
            Graduated
        }

        public Student(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduation)
        {
            _id = id;
            _givenName = givenName;
            _surName = surName;
            _startDate = startDate.Date;
            _endDate = endDate.Date;
            _graduationDate = graduation.Date;

            if (_graduationDate > _endDate)
            {
                _status = ActivityStatus.Dropout;
            }
            else
            {
                if (_graduationDate <= DateTime.Today)
                {
                    _status = ActivityStatus.Graduated;
                }
                else
                {
                    if (_startDate.AddDays(15) < DateTime.Today)
                    {
                        _status = ActivityStatus.Active;
                    }
                    else
                    {
                        _status = ActivityStatus.New;
                    }
                }
            }
        }

        public string GivenName
        {
            get => _givenName;
            set => _givenName = value;
        }

        public string SurName
        {
            get => _surName;
            set => _surName = value;
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public DateTime GraduationDate
        {
            get => _graduationDate;
            set => _graduationDate = value;
        }

        public ActivityStatus Status
        {
            get => _status;
        }

        public int Id
        {
            get => _id;
        }

        public override string ToString()
        {
            return $"Student id: {_id}, \nStudent name: {_givenName} {_surName}. \nStatus: {_status} \nStart and end date: {_startDate.ToString("d")} : {_endDate.ToString("d")}. \nGraduation date: {_graduationDate.ToString("d")}. \n";
        }
    }
}
