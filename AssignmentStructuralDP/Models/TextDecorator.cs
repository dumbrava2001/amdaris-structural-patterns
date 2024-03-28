using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public abstract class TextDecorator : ITextCreator
{
    protected readonly ITextCreator _text;

    protected TextDecorator(ITextCreator text)
    {
        _text = text;
    }

    public abstract string GetText();
}