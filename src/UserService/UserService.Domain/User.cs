using System.ComponentModel.DataAnnotations;

namespace UserService.Domain;

/// <summary>
/// Класс пользователя
/// </summary>
public class User
{
    /// <summary>
    /// Идентификатор пользователя в формате Snowflake
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Username { get; set; } = "";

    /// <summary>
    /// Пароль пользователя
    /// </summary>
    public string Password { get; set; } = "";

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Уровень доступа пользователя
    /// </summary>
    public int AccessLevel { get; set; } = 1;

    /// <summary>
    /// Список отчётов, созданных пользователем
    /// </summary>
    public List<long> ReportIds { get; set; } = new List<long>();
}
