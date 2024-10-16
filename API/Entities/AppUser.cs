using System.ComponentModel.DataAnnotations;

namespace API.Entities;

/// <summary>
/// The app user entity
/// </summary>
public class AppUser
{
    /// <summary>
    /// The unique identifier for the app user
    /// </summary>
    [Key]
    public int UserId { get; set; }

    /// <summary>
    /// The user name for the app user
    /// </summary>
    public required string UserName { get; set; }

    /// <summary>
    /// the user's password hash
    /// </summary>
    public required byte[] PasswordHash { get; set; }

    /// <summary>
    /// the user's password salt
    /// </summary>
    public required byte[] PasswordSalt { get; set; }
}
