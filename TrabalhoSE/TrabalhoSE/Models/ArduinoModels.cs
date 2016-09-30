using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TrabalhoSE.Models
{
    public class SensorData
    {
        [Key]
        public int Id { get; set; }

        public float? Temperature { get; set; }
        public float? Humidity { get; set; }
        public float? Power { get; set; }
        public DateTime Time { get; set; }
    }

    public class ArduinoContext : DbContext
    {
        public ArduinoContext() : base("DefaultConnection") { }

        public DbSet<SensorData> SensorData { get; set; }
    }
}