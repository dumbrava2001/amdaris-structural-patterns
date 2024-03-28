using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public abstract class TextDecorator : ITextCreator
{
    protected readonly ITextCreator Text;

    protected TextDecorator(ITextCreator text)
    {
        Text = text;
    }

    public abstract string GetText();

    public ITextCreator RemoveDecorator(Type type)
    {
        if (GetType() == type)
        {
            return Text;
        }

        return Text is TextDecorator decorator ? decorator.RemoveDecorator(type) : this;
    }
    
}