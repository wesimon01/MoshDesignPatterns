namespace MoshDesignPatterns.Domain.Creational.Builder.Demo
{
    public class Presentation
    {
        private List<Slide> slides = new();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            foreach(var slide in slides) 
            {
                builder.AddSlide(slide);
            }
        }
    }
}
