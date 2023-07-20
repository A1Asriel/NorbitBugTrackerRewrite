using ReportService.Domain.Entities;

namespace ReportService.Domain.Interfaces;
public interface IReportManager
{
    /// <summary>
    /// Получить список всех отчётов
    /// </summary>
    /// <returns>Список со всеми отчётами</returns>
    List<Report> GetAll();

    /// <summary>
    /// Получить отчёт с указанным идентификатором
    /// </summary>
    /// <param name="id">Идентификатор отчёта</param>
    /// <returns>Объект отчёта</returns>
    Report? GetById(long id);

    /// <summary>
    /// Создать новый отчёт
    /// </summary>
    /// <param name="report">Исходный объект отчёта</param>
    /// <returns>Добавленный объект отчёта</returns>
    Report Create(Report report);

    /// <summary>
    /// Изменить отчёт
    /// </summary>
    /// <param name="report">Новый объект отчёта</param>
    /// <returns>Изменённый объект отчёта</returns>
    Report? Edit(Report report);

    /// <summary>
    /// Удалить отчёт
    /// </summary>
    /// <param name="id">Идентификатор удаляемого отчёта</param>
    /// <returns>Данные удалённого отчёта</returns>
    Report? Delete(long id);

    /// <summary>
    /// Связать отчёты
    /// </summary>
    /// <param name="reportId1">Идентификатор первого отчёта</param>
    /// <param name="reportId2">Идентификатор второго отчёта</param>
    /// <returns>Список связанных отчётов</returns>
    List<Report> LinkReports(long reportId1, long reportId2);

    /// <summary>
    /// Отвязать отчёты
    /// </summary>
    /// <param name="reportId1">Идентификатор первого отчёта</param>
    /// <param name="reportId2">Идентификатор второго отчёта</param>
    /// <returns>Список отвязанный отчётов</returns>
    List<Report> UnlinkReports(long reportId1, long reportId2);

    /// <summary>
    /// Добавить комментарий к отчёту
    /// </summary>
    /// <param name="reportId">Идентификатор отчёта</param>
    /// <param name="comment">Объект комментария</param>
    /// <returns>Изменённый объект отчёта</returns>
    Report? AddComment(long reportId, Comment comment);

    /// <summary>
    /// Удалить комментарий из отчёта
    /// </summary>
    /// <param name="reportId">Идентификатор отчёта</param>
    /// <param name="commentId">Идентификатор комментария</param>
    /// <returns>Изменённый объект отчёта</returns>
    Report? RemoveComment(long reportId, long commentId);
}
