using Graphics2.ECS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics2
{
    public class CubeBuilder : Builder
    {
        public CubeBuilder(string fragShaderPath, string vertShaderPath)
            : base(fragShaderPath, vertShaderPath)
        {
        }

        public Cube BuildCube(int resolution)
        {
            Cube cube = new(resolution);
            CubeVerticesLoader.Load(cube);
            cube.AddComponent(CubeMeshCreator.Create(cube));
            cube.AddComponent(new RenderProps(_fragShaderPath, _vertShaderPath, null, OpenTK.Graphics.OpenGL.PrimitiveType.Triangles));
            cube.AddComponent(new Transform());
            cube.GetComponent<Transform>()?.Translate(new OpenTK.Mathematics.Vector3(5.0f, 0.0f, 0.0f));
            cube.GetComponent<Transform>()?.Scale(2.0f);
            cube.AddComponent(new MeshRenderer());
            cube.GetComponent<MeshRenderer>().Init();
            return cube;
        }
    }
}
