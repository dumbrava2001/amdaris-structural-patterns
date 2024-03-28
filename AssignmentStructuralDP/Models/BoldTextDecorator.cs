using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public class BoldTextDecorator : TextDecorator
{
    public BoldTextDecorator(ITextCreator text) : base(text)
    {
    }

    public override string GetText()
    {
        return $"<bold>\n{_text.GetText()}\n</bold>";
    }
    
}