using System;
using System.Collections.Generic;

namespace IntexDatabaseConnection.Models
{
    public partial class Frontend
    {
        public int Id { get; set; }
        public string? Burialid { get; set; }
        public string? Textilecolor { get; set; }
        public string? Textilestructure { get; set; }
        public char? Sex { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Estimatestature { get; set; }
        public string? Ageatdeath { get; set; }
        public char? Headdirection { get; set; }
        public string? Textilefunction { get; set; }
        public char? Haircolor { get; set; }
        public string? Facebundles { get; set; }
    }
}
