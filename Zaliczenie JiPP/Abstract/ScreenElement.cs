using Zaliczenie_JiPP.Interfaces;

namespace Zaliczenie_JiPP.Abstract
{
    public abstract class ScreenElement : ScreenInterface
    {
        protected int width, height, linesCount, lineLettersCount;

        protected ScreenElement(int width, int height)
        {
            this.width  = width;
            this.height = height;
        }

        protected ScreenElement(Config config) : this(config.Width, config.Height){}

        abstract public void draw();

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int LinesCount
        {
            get
            {
                return linesCount;
            }
        }
    }
}
