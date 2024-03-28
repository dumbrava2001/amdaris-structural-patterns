using AssignmentStructuralDP.Models;

namespace AssignmentStructuralDP;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Creating a new text with bold style");
        var userText = new BaseText("Breaking news");
        var boldText = new BoldTextDecorator(userText);
        Console.WriteLine(boldText.GetText());

        Console.WriteLine("\nAdding Italic style to text");
        var italicText = new ItalicTextDecorator(boldText);
        Console.WriteLine(italicText.GetText());

        Console.WriteLine("\nAdding underline text decoration");
        var underlinedText = new UnderlineTextDecorator(italicText);
        Console.WriteLine(underlinedText.GetText());

        Console.WriteLine("\nAdding text color decoration");
        var redText = new ColorTextDecorator(underlinedText, "red");
        Console.WriteLine(redText.GetText());

        Console.WriteLine("\nRemoving color style decoration");
        var noStyleText = redText.RemoveDecorator(typeof(ColorTextDecorator));
        Console.WriteLine(noStyleText.GetText());
    }
}