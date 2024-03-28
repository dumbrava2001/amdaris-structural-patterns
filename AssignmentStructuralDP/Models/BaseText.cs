using AssignmentStructuralDP.Services;

namespace AssignmentStructuralDP.Models;

public class BaseText : ITextCreator
{
    public string Text { get; set; }

    public BaseText(string text)
    {
        Text = text;
    }

    public string GetText()
    {
        return Text;
    }
}