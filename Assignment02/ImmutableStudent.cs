using System;


namespace ImmutableStudent
{
    public record ImmutableStudent()
    {
        public int _id { get; init; }
        public string _givenName { get; init; }
        public string _surName { get; init; }
        public DateTime _startDate { get; init; }
        public DateTime _endDate { get; init; }
        public DateTime _graduationDate { get; init; }

        public ActivityStatus _status { get; init; }

        public enum ActivityStatus
        {
            New,
            Active,
            Dropout,
            Graduated
        }

        public ImmutableStudent(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime gradDate) 
        : this()
        {    
            this._id = id;
            _givenName = givenName;
            _surName = surName;
            _startDate = startDate;
            _endDate = endDate;
            _graduationDate = gradDate;
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

        public override string ToString()
        {
            return $"Student id: {_id}, \nStudent name: {_givenName} {_surName}. \nStatus: {_status} \nStart and end date: {_startDate.ToString("d")} : {_endDate.ToString("d")}. \nGraduation date: {_graduationDate.ToString("d")}. \n";
        }
    }
}
