﻿using Medical.Models;
using Medical.Utils;

namespace Medical.DTOs.ProvidersDTOs;
public class RegisterProviderDTO
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public string? bio { get; set; }
    public Shift Shift { get; set; }  
    public float Rate { get; set; }
    public List<AddDoctorToProviderDTO> Doctors { get; set; } = new List<AddDoctorToProviderDTO>();
}