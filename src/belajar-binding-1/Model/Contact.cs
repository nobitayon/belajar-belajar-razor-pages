namespace belajar_binding_1.Model;

public class Contact
{
    public Guid ContactId { get; set; } = Guid.NewGuid();
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
}
