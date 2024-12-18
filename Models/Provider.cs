﻿using Medical.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Medical.Models;

// Privider == Clinic
public class Provider : AppUser 
{
    public string? bio { get; set; }

    [Required]
    public Shift Shift { get; set; } // shift clinc

    [Range(0, 5)]
    public float Rate { get; set; }

    [Column("photo")]
    public string? PhotoId { get; set; }
    public virtual List<Doctor> Doctors { get; set; } = new List<Doctor>();
    public virtual List<Record> Records { get; set; } = new List<Record>();
}
