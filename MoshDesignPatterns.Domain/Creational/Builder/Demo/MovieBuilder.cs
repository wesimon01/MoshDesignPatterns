namespace MoshDesignPatterns.Domain.Creational.Builder.Demo
{
    public class MovieBuilder : IPresentationBuilder
    {
        public Movie Movie { get; private set; } = new();

        public void AddSlide(Slide slide)
        {
            Movie.AddFrame(slide.Text);
        }
    }
}
