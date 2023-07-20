using System.ComponentModel.DataAnnotations;

namespace ReportService.Domain.Entities;

/// <summary>
/// Класс отчёта
/// </summary>
public class Report
{
    /// <summary>
    /// Идентификатор отчёта в формате Snowflake
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, создавшего отчёт
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// Идентификатор проекта, в котором содержится отчёт
    /// </summary>
    public long ProjectId { get; set; }

    /// <summary>
    /// Заголовок отчёта
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Описание отчёта
    /// </summary>
    public string Description { get; set; } = "";

    /// <summary>
    /// Тип отчёта
    /// </summary>
    public Enums.ReportType Type { get; set; } = Enums.ReportType.Bug;

    /// <summary>
    /// Категория отчёта
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Приоритет отчёта
    /// </summary>
    public Enums.ReportPriority Priority { get; set; } = Enums.ReportPriority.Unassigned;

    /// <summary>
    /// Статус отчёта
    /// </summary>
    public Enums.ReportStatus Status { get; set; } = Enums.ReportStatus.Open;

    /// <summary>
    /// Список связанных отчётов
    /// </summary>
    public List<long> LinkedReportIds { get; set; } = new List<long>();

    /// <summary>
    /// Список комментариев
    /// </summary>
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
