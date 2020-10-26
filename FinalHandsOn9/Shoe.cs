using System;

namespace FinalHandsOn9
{
    class Shoe
    {
        int size;
        string color;
        string secondaryColor;
        bool openToe;
        string laceColor;

        public Shoe(int size, string color, string secondaryColor, bool openToe, string laceColor)
        {
            this.size = size;
            this.color = color;
            this.secondaryColor = secondaryColor;
            this.openToe = openToe;
            this.laceColor = laceColor;
        }

        public Shoe()
        {
        }

        public int Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string SecondaryColor { get => secondaryColor; set => secondaryColor = value; }
        public bool OpenToe { get => openToe; set => openToe = value; }
        public string LaceColor { get => laceColor; set => laceColor = value; }
        public override string ToString()
        {
            return "Size: " + size + " Color: " + color + " Secondary Color: " + secondaryColor + " Open Toe: " + openToe + " Lace Color: "+laceColor;
        }
    }
}
