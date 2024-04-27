namespace MoshDesignPatterns.Domain.Creational.Builder.Demo
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        public PdfDocument Document { get; private set; } = new();

        public void AddSlide(Slide slide)
        {
            Document.AddPage(slide.Text);
        }
    }
}
