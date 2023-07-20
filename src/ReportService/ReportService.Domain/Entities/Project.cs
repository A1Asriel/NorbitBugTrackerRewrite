using System.ComponentModel.DataAnnotations;

namespace ReportService.Domain.Entities;

/// <summary>
/// Класс проекта
/// </summary>
public class Project
{
    /// <summary>
    /// Идентификатор проекта в формате Snowflake
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Имя проекта
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Описание проекта
    /// </summary>
    public string Description { get; set; } = "";

    /// <summary>
    /// Уровень видимости проекта
    /// </summary>
    public Enums.AccessLevel Visibility { get; set; } = Enums.AccessLevel.None;

    /// <summary>
    /// Список отчётов
    /// </summary>
    public List<long> ReportIds { get; set; } = new List<long>();

    /// <summary>
    /// Список категорий
    /// </summary>
    public List<string> Categories { get; set; } = new List<string>();
}
