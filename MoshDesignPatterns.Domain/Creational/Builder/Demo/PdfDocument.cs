namespace MoshDesignPatterns.Domain.Creational.Builder.Demo
{
    public class PdfDocument
    {
        public void AddPage(string? text)
        {
            Console.WriteLine($"Adding a page to PDF with text: {text}");
        }
    }
}
