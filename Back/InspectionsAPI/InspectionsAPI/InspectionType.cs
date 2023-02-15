using System.ComponentModel.DataAnnotations;

namespace InspectionsAPI
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string InspectionName { get; set; } = string.Empty;
    }
}
