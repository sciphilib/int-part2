using Graphics2.ECS;
using System.Numerics;
using System.Security.Cryptography;

namespace Graphics2
{
    public class Cube : Entity
    {
        public float Resolution     { get; }
        public float Splitting      { get; }
        public int VerticesPerSide  { get; }
        public int VerticesLines    { get; }

        public Cube(float resolution)
        {
            Resolution = resolution;
            Splitting = (float)Math.Pow(2.0f, resolution);
            VerticesLines = (int)Splitting + 1;
            VerticesPerSide = (int)Math.Pow(Splitting + 1, 2);
            m_CubeSides = new Side[6];

            for (int i = 0; i < 6; i++)
            {
                m_CubeSides[i] = new(VerticesLines);
            }
        }

        public Side GetSide(int side)
        {
            return m_CubeSides[side];
        }

        public float GetResolution()
        {
            return Resolution;
        }

        private Side[] m_CubeSides;
    }
}
