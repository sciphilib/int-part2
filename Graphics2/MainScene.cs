using Graphics2.ECS;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphics2
{
    public class MainScene : Scene
    {
        public MainScene()
        {
            var outlineBuilder = new OutlineBuilder("Shaders\\FragmentOutlineShader.glsl", "Shaders\\VertexOutlineShader.glsl");
            var morfedOutlineBuilder = new OutlineBuilder("Shaders\\FragmentCubeToSphere.glsl", "Shaders\\VertexCubeToSphere.glsl");
            var cubeBuilder = new CubeBuilder("Shaders\\FragmentObjectShader.glsl", "Shaders\\VertexObjectShader.glsl");

            // cube
            var cube1 = cubeBuilder.BuildCube(2);

            // outlines
            var cubeOutline1 = outlineBuilder.BuildCubeOutline(cube1);
            var mcubeOutline1 = morfedOutlineBuilder.BuildCubeOutline(cube1);
            mcubeOutline1.GetComponent<Transform>().Translate(new OpenTK.Mathematics.Vector3(1.25f, 0.0f, 0.0f));

            AddObject(cubeOutline1);
            AddObject(mcubeOutline1);
        }
    }
}
