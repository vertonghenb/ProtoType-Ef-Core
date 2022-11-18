namespace Domain;

public class Customer : Entity
{
    public string Name { get; set; }

    public IReadOnlyCollection<Box> Boxes => boxes.AsReadOnly();

    private List<Box> boxes = new();
}

