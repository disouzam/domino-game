using System;

namespace domino_models
{
    public class Tile
    {
        private const int MAX_END_VALUE = 6;

        private int _end1 = int.MinValue;

        private int _end2 = int.MinValue;

        public Tile (int end1, int end2)
        {
            if (end1 == maxEndValue || end2 == maxEndValue)
            {
                throw new InvalidOperationException($"Maximum end value is {MAX_END_VALUE}");
            }
            _end1 = end1;
            _end2 = end2;
        }

    }
}
