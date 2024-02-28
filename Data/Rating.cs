using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterAPI.Data
{
    public class Rating
    {
    [Key] //primary key
    public int Id { get; set; }

    [Required] // NOT NULL
    [Range(0, 5)]
    public double Score { get; set; }

    [Required]
    [ForeignKey("Restaurant")]
    public int RestaurantId { get; set; }
    }
}