using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectScope.Data
{
    public class Chart
    {
        public int Id { set; get; } = 0;
        public String Name { set; get; } = "";
        public int TotalCases { set; get; } = 0;
        public int Total { set; get; } = 0;
        public String DathesParsintg => (this.TotalCases * 100) / this.Total + "%";


        public List <Chart> GetCharts()
        {
            var Charts = new List<Chart>();
            Charts.Add(new Chart() { Id = 1, Name = "Amman",TotalCases=1275857 , Total =50});
            Charts.Add(new Chart() { Id = 2, Name = "Arbid", TotalCases = 307480, Total = 20 });
            Charts.Add(new Chart() { Id = 3, Name = "Zarqa", TotalCases = 792665, Total = 30 });
            Charts.Add(new Chart() { Id = 4, Name = "Ajlon", TotalCases = 125557, Total = 60 });
            Charts.Add(new Chart() { Id = 5, Name = "salt", TotalCases = 80189, Total = 40 });
            return Charts;

        }
    }
}
