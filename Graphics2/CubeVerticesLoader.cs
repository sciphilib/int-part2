using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphics2
{
    internal class CubeVerticesLoader
    {
        public static void Load(Cube cube)
        {
            int currSide = 0;

            const float cubeLength = 2.0f;
            float parts = cubeLength / cube.Splitting;

            float coordX;
            float coordY;
            float coordZ;

            float leftCoordValue = - (cubeLength / 2);

            // Sides: 0, 2 (X, Y)
            coordX = leftCoordValue;
            coordY = leftCoordValue;
            coordZ = leftCoordValue;
            for (int sides = 0; sides < 2; sides++)
            {
                for (int i = 0; i < cube.VerticesLines; i++)
                {
                    coordX = leftCoordValue;
                    for (int j = 0; j < cube.VerticesLines; j++)
                    {
                        cube.GetSide(currSide).vertices[i, j] = new Vector3(coordX, coordY, coordZ + (cubeLength * sides));
                        coordX += parts;
                    }
                    coordY += parts;
                }
                coordY = leftCoordValue;
                currSide++;
            }

            // Sides: 1, 3 (Z, Y)
            coordX = leftCoordValue;
            coordY = leftCoordValue;
            coordZ = leftCoordValue;
            for (int sides = 0; sides < 2; sides++)
            {
                for (int i = 0; i < cube.VerticesLines; i++)
                {
                    coordZ = leftCoordValue;
                    for (int j = 0; j < cube.VerticesLines; j++)
                    {
                        cube.GetSide(currSide).vertices[i, j] = new Vector3(coordX + (cubeLength * sides), coordY, coordZ);
                        coordZ += parts;
                    }
                    coordY += parts;
                }
                coordY = leftCoordValue;
                currSide++;
            }

            //Sides: 4, 5(X, Z)
            coordX = leftCoordValue;
            coordY = leftCoordValue;
            coordZ = leftCoordValue;
            for (int sides = 0; sides < 2; sides++)
            {
                for (int i = 0; i < cube.VerticesLines; i++)
                {
                    coordX = leftCoordValue;
                    for (int j = 0; j < cube.VerticesLines; j++)
                    {
                        cube.GetSide(currSide).vertices[i, j] = new Vector3(coordX, coordY + (cubeLength * sides), coordZ);
                        coordX += parts;
                    }
                    coordZ += parts;
                }
                coordZ = leftCoordValue;
                currSide++;
            }
        }
    }
}
