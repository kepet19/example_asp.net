using Microsoft.AspNetCore.Mvc;
using datatable_test.Models;
using Type = datatable_test.Models.Type;

namespace datatable_test.Controllers;

public class GroupController : Controller
{
    private readonly ILogger<GroupController> _logger;

    public GroupController(ILogger<GroupController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("Index");
        return View(get_groups().Select(x => x.Item1));
    }

    public IActionResult Group(String name)
    {
        _logger.LogInformation($"Group name: {name}");

        return View(get_groups().FirstOrDefault(x => x.Item1.Name == name));
    }


    private List<Tuple<Group, User>> get_groups()
    {
        return new List<Tuple<Group, User>>
        {
            Tuple.Create(new Group("r_sometest", Type.Role), new User("kevin", "kkmp")),
            Tuple.Create(new Group("r_next", Type.Role), new User("kevin", "kkmp")),
            Tuple.Create(new Group("s_next", Type.Security), new User("kevin", "kkmp")),
            Tuple.Create(new Group("r_what_test", Type.Role), new User("troels", "tjse")),
            Tuple.Create(new Group("s_what_test", Type.Security), new User("kevin", "kkmp")),
            Tuple.Create(new Group("r_jep_uff", Type.Role), new User("troels", "tjse")),
        };
    }
}
