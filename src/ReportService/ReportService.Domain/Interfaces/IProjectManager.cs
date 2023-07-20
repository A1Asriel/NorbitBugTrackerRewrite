using ReportService.Domain.Entities;

namespace ReportService.Domain.Interfaces;
public interface IProjectManager
{
    /// <summary>
    /// Получить список всех проектов
    /// </summary>
    /// <returns>Список со всеми проектами</returns>
    List<Project> GetAll();

    /// <summary>
    /// Получить проект с указанным идентификатором
    /// </summary>
    /// <param name="id">Идентификатор проекта</param>
    /// <returns>Объект проекта</returns>
    Project? GetById(long id);

    /// <summary>
    /// Создать новый проект
    /// </summary>
    /// <param name="project">Исходный объект проекта</param>
    /// <returns>Добавленный объект проекта</returns>
    Project Create(Project project);

    /// <summary>
    /// Изменить проекта
    /// </summary>
    /// <param name="project">Новый объект проекта</param>
    /// <returns>Изменённый объект проекта</returns>
    Project? Edit(Project project);

    /// <summary>
    /// Удалить проект
    /// </summary>
    /// <param name="id">Идентификатор удаляемого проекта</param>
    /// <returns>Данные удалённого проекта</returns>
    Project? Delete(long id);

    /// <summary>
    /// Добавить отчёт к проекту
    /// </summary>
    /// <param name="projectId">Идентификатор проекта</param>
    /// <param name="reportId">Идентификатор отчёта</param>
    /// <returns>Изменённый объект проекта</returns>
    Project? AddReport(long projectId, long reportId);

    /// <summary>
    /// Убрать отчёт из проекта
    /// </summary>
    /// <param name="projectId">Идентификатор проекта</param>
    /// <param name="reportId">Идентификатор отчёта</param>
    /// <returns>Изменённый объект проекта</returns>
    Project? RemoveReport(long projectId, long reportId);
}
