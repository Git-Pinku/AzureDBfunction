using Microsoft.Azure.Cosmos.Table;

namespace processcsvdata
{
    public class Session : TableEntity
    {
        public Session()
        {
        }

        public Session(string subject, string instructor)
        {
            PartitionKey = subject;
            RowKey = instructor;
        }

        public string Lectures { get; set; }
        public string Labs { get; set; }
        public double Points { get; set; }
        public bool IsWeekend { get; set; }
    }
}
