using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    [MaxLength(100)]
    public required string Username { get; set; }
    
    [Required]
    [MaxLength(100)]
    public required string Password { get; set; }
}
