using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public class UnderlineTextDecorator : TextDecorator
{
    public UnderlineTextDecorator(ITextCreator text) : base(text)
    {
    }

    public override string GetText()
    {
        return $"<underline>\n{Text.GetText()}\n</underline>";
    }
}