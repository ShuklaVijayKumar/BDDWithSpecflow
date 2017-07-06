using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowSamples
{
    [Binding]
    public class DataTransform
    {
        [StepArgumentTransformation(@"(\d+) days ago")]
        public DateTime DaysAgoTransform(int daysAgo)
        {
            return DateTime.Today.AddDays(-daysAgo);
        }

        //[StepArgumentTransformation(@"(\d+) days ago")]
        //public DateTime DaysAgoTransform(int daysAgo)
        //{
        //    return DateTime.Today.AddDays(-daysAgo);
        //}
    }
}
