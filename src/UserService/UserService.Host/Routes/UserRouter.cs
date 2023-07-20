using UserService.Domain;
using UserService.Infrastructure.Managers;

namespace UserService.Host.Routes;

/// <summary>
/// Роутер для работы API пользователей
/// </summary>
public static class UserRouter
{
    public static WebApplication AddUserRouter(this WebApplication application)
    {
        RouteGroupBuilder userGroup = application.MapGroup("/api/users");
        userGroup.MapGet("/", GetAllUserIDs);
        userGroup.MapGet("/{id:long}", GetUser);
        userGroup.MapPost("/register", AddUser);
        userGroup.MapGet("/{id:long}/delete", RemoveUser);
        userGroup.MapPut("/{id:long}/edit", EditUser);
        return application;
    }

    private static IResult GetAllUserIDs(IUserManager userManager)
    {
        var users = userManager.GetAll();
        List<long> userids = new();
        foreach (User user in users)
        {
            userids.Add(user.Id);
        }
        return Results.Ok(userids);
    }

    private static IResult GetUser(long id, IUserManager userManager)
    {
        var users = userManager.GetAll();
        User? user = users.FirstOrDefault(x => x.Id == id);
        if (user == null)
            return Results.NotFound();
        else
            return Results.Ok(user);
    }

    private static IResult AddUser(string username, string password, string name, IUserManager userManager)
    {
        var users = userManager.GetAll();
        User? check_user = users.FirstOrDefault(x => x.Username == username.ToLower());
        if (check_user != null)
            return Results.StatusCode(403);

        User user = new User()
        {
            Id = IDManager.GetID(),
            Username = username.ToLower(),
            Password = password,
            Name = name
        };
        userManager.Create(user);
        return Results.Ok(user.Id);
    }

    private static IResult RemoveUser(long id, IUserManager userManager)
    {
        var users = userManager.GetAll();
        User? user = users.FirstOrDefault(x => x.Id == id);
        if (user == null)
            return Results.NotFound();

        user.AccessLevel = 0;
        userManager.Edit(user);
        return Results.Ok(user);
    }

    private static IResult EditUser(long id, string? username, string? password, string? name, int? accessLevel, IUserManager userManager)
    {
        var users = userManager.GetAll();
        User? user = users.FirstOrDefault(x => x.Id == id);
        if (user == null)
            return Results.NotFound();

        if (username != null)
            user.Username = username.ToLower();
        if (password != null)
            user.Password = password;
        if (name != null)
            user.Name = name;
        if (accessLevel != null)
            user.AccessLevel = (int)accessLevel;
        userManager.Edit(user);
        return Results.Ok(user);
    }
}
