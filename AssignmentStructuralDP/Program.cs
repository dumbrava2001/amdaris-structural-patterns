using AssignmentStructuralDP.Models;

namespace AssignmentStructuralDP;

internal static class Program
{
    public static void Main(string[] args)
    {
        var userText = new BaseText("Breaking news");
        var boldText = new BoldTextDecorator(userText);
        Console.WriteLine(boldText.GetText());

        var italicText = new ItalicTextDecorator(boldText);
        Console.WriteLine(italicText.GetText());

        var underlinedText = new UnderlineTextDecorator(italicText);
        Console.WriteLine(underlinedText.GetText());

        var redText = new ColorTextDecorator(underlinedText, "red");
        Console.WriteLine(redText.GetText());
    }
}