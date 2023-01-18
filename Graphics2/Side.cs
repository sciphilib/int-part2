using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphics2
{
    public class Side
    {
        public Side(int verticesCount)
        {
            vertices = new Vector3[verticesCount, verticesCount];
        }

        public Vector3[,] vertices;
    }
}
