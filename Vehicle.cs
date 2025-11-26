using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esakay.Models
{
    [Table("vehicles")] 
    public class Vehicle
    {
        [Key]
        [Column("vehicle_id")]
        public int Id { get; set; }

        [Column("plate_number")]
        public string PlateNumber { get; set; } = string.Empty;

        [Column("vehicle_type")]
        public string VehicleType { get; set; } = string.Empty; // Tricycle, Jeepney

        [Column("route_name")]
        public string RouteName { get; set; } = string.Empty;

        [Column("current_latitude")]
        public decimal CurrentLatitude { get; set; }

        [Column("current_longitude")]
        public decimal CurrentLongitude { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }
    }
}