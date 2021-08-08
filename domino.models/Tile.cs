using System;
using System.Text;

namespace domino.models
{
    public class Tile
    {
        private const int MAX_END_VALUE = 6;

        private int _end1 = int.MinValue;

        private int _end2 = int.MinValue;

        public Tile (int end1, int end2)
        {
            if (end1 > MAX_END_VALUE || end2 > MAX_END_VALUE)
            {
                throw new InvalidOperationException($"Maximum end value is {MAX_END_VALUE}");
            }

            if (end1 < 0 || end2 < 0)
            {
                throw new InvalidOperationException($"Negative values are not allowed.");
            }

            _end1 = end1;
            _end2 = end2;
        }

        public int end1
        {
            get
            {
                return _end1;
            }
        }

        public int end2
        {
            get
            {
                return _end2;
            }
        }

        public override string ToString()
        {
            int min = end1 < end2 ? end1 : end2;
            int max = end1 < end2 ? end2 : end1;

            var sb = new StringBuilder();
            sb.AppendLine($"Tile...{min}-{max}");
            return sb.ToString();
        }
    }
}
