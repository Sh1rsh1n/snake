using System.Collections.Generic;

namespace Snake
{
    class Wall
    {
        List<Figura> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figura>();

            HorizontLine upLine = new HorizontLine(0, mapWidth - 2, 0, '+');
            HorizontLine downLine = new HorizontLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figura figura)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figura))
                {
                    return true;
                }
            }
            return false;
        }

        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}