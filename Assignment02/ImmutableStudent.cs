using System;


namespace ImmutableStudent
{
    public record ImmutableStudent()
    {
        public int Id { get; init; }
        public string GivenName { get; init; }
        public string SurName { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }

        public ActivityStatus Status { get; init; }

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
            this.Id = id;
            this.GivenName = givenName;
            this.SurName = surName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GraduationDate = gradDate;
            if (GraduationDate > endDate)
            {
                this.Status = ActivityStatus.Dropout;
            }
            else
            {
                if (GraduationDate <= DateTime.Today)
                {
                    this.Status = ActivityStatus.Graduated;
                }
                else
                {
                    if (startDate.AddDays(15) < DateTime.Today)
                    {
                        this.Status = ActivityStatus.Active;
                    }
                    else
                    {
                        this.Status = ActivityStatus.New;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Student id: {Id}, \nStudent name: {GivenName} {SurName}. \nStatus: {Status} \nStart and end date: {StartDate.ToString("d")} : {EndDate.ToString("d")}. \nGraduation date: {GraduationDate.ToString("d")}. \n";
        }
    }
}
