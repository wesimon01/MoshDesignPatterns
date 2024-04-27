namespace MoshDesignPatterns.Domain.Prototype
{
    public class Text : IComponent
    {
        public string content { get; private set; }

        public Text(string content)
        {
            this.content = content;
        }

        public IComponent Clone()
        {
            Text newText = new(content);
            return newText;
        }
    }
}
