using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public class ItalicTextDecorator : TextDecorator
{
    public ItalicTextDecorator(ITextCreator text) : base(text)
    {
    }

    public override string GetText()
    {
        return $"<italic>\n{_text}\n</italic>";
    }
}