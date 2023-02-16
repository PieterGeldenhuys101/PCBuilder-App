using System.ComponentModel.DataAnnotations;

namespace InspectionsAPI
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Status { get; set; } = string.Empty;

        [StringLength(2000)]
        public string Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? InspectionType { get; set; }
    }
}


// Add this to a folder - Pieter
