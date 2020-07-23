namespace StopClock
{
    public class DataSet
    {
        public string WorkType { get; set; }
        public string Duration { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public DataSet() { }

        public DataSet(string workType, string duration, string customer, string description)
        {
            WorkType = workType;
            Duration = duration;
            Customer = customer;
            Description = description;
        }
    }
}
