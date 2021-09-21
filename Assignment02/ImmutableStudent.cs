using System;


namespace ImmutableStudent
{
    public record ImmutableStudent
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

        public override string ToString()
        {
            return $"Student id: {_id}, \nStudent name: {_givenName} {_surName}. \nStatus: {_status} \nStart and end date: {_startDate.ToString("d")} : {_endDate.ToString("d")}. \nGraduation date: {_graduationDate.ToString("d")}. \n";
        }
    }
}
