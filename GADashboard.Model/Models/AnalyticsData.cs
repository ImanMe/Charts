using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GADashboard.Model.Models
{
    public class AnalyticsData
    {
        public int Id { get; set; }

        [StringLength(850)]
        public string LandingPagePath { get; set; }

        [StringLength(250)]
        public string ClinetId { get; set; }

        [StringLength(250)]
        public string SessionId { get; set; }

        [StringLength(250)]
        public string Source { get; set; }

        [StringLength(250)]
        public string DealerId { get; set; }

        [StringLength(250)]
        public string Sessions { get; set; }

        [StringLength(250)]
        public string SessionDuration { get; set; }

        [StringLength(250)]
        public string PageViews { get; set; }

        [StringLength(250)]
        public string BasicFlowVisits { get; set; }

        [StringLength(250)]
        public string BasicFlowComplete { get; set; }

        [StringLength(250)]
        public string PreqFlowVisits { get; set; }

        [StringLength(250)]
        public string PreqFlowComplete { get; set; }

        [StringLength(250)]
        public string FullFlowVisits { get; set; }

        [StringLength(250)]
        public string FullFlowComplete { get; set; }

        [StringLength(250)]
        public string WebRefId { get; set; }

        public DateTime TimeOfRetrieval { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateOfVisit { get; set; }

    }
}
