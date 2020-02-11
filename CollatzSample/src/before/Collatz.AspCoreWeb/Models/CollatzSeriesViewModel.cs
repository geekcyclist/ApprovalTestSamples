using System.Linq;
using Collatz.Core;
using Microsoft.AspNetCore.Mvc;

namespace Collatz.AspCoreWeb.Models
{
    [BindProperties]
    public class CollatzSeriesViewModel
    {
        public int StartValue { get; set; }
        public CollatzSeries Series { get; private set; }
        public int MaxValue { get; private set; }
        public int TotalSteps { get; private set; }
        
        public void Populate()
        {
            Series = new CollatzSeries(StartValue);
            MaxValue = Series.Steps.Max(s => s.Value);
            TotalSteps = Series.Steps.Last().Step;
        }
    }
}
