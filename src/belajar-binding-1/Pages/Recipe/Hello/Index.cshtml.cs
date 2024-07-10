using belajar_binding_1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace belajar_binding_1.Pages.Recipe.Hello;

public class IndexModel : PageModel
{

    public IActionResult OnGet()
    {
        return Page();
    }

    public void OnPost(List<TestModel> model)
    {
        Console.WriteLine(model.Count);
    }
}
