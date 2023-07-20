namespace UserService.Domain;
public interface IUserManager
{
    /// <summary>
    /// Получить список всех пользователей
    /// </summary>
    /// <returns>Список со всеми пользователями</returns>
    List<User> GetAll();

    /// <summary>
    /// Получить пользователя с указанным идентификатором
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns>Объект пользователя</returns>
    User? GetById(long id);

    /// <summary>
    /// Создать нового пользователя
    /// </summary>
    /// <param name="user">Исходный объект пользователя</param>
    /// <returns>Добавленный объект пользователя</returns>
    User Create(User user);

    /// <summary>
    /// Изменить пользователя
    /// </summary>
    /// <param name="user">Новый объект пользователя</param>
    /// <returns>Изменённый объект пользователя</returns>
    User? Edit(User user);

    /// <summary>
    /// Удалить данные пользователя из системы
    /// </summary>
    /// <param name="id">Идентификатор удаляемого пользователя</param>
    /// <returns>Данные удаленного пользователя</returns>
    User? Delete(long id);

    /// <summary>
    /// Добавить идентификатор отчёта в профиль пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <param name="reportId">Идентификатор отчёта</param>
    /// <returns>Изменённый объект пользователя</returns>
    User? AddReportId(long userId, long reportId);
}
