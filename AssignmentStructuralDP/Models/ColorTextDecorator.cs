using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public class ColorTextDecorator : TextDecorator
{
    public string Color { get; set; }

    public ColorTextDecorator(ITextCreator text, string color) : base(text)
    {
        Color = color;
    }

    public override string GetText()
    {
        return $"<text-color: {Color}>\n{Text.GetText()}\n</text-color>";
    }
    
}