using belajar_binding_1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace belajar_binding_1.Pages.Recipe.Add;

public class IndexModel : PageModel
{
    //[BindProperty]
    //public List<Contact>? Contacts { get; set; }


    public void OnPost(List<Contact>? contacts)
    {
        if(contacts != null)
        {
            Console.WriteLine($"Contacts length: {contacts.Count()}");
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Id: {contact.ContactId}");
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"First Name: {contact.LastName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine("=============");
            }
            
        }
    }
}
