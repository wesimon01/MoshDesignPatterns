﻿namespace MoshDesignPatterns.Domain.Structural.Adapter.Demo
{
    public class ImageView
    {
        private readonly Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}
