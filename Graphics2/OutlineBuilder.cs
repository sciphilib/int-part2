using Graphics2.ECS;
using OpenTK.Mathematics;

namespace Graphics2
{
    public class OutlineBuilder : Builder
    {
        public OutlineBuilder(string fragShaderPath, string vertShaderPath)
            : base(fragShaderPath, vertShaderPath) 
        {
        }

        public Outline BuildCubeOutline(Cube cube)
        {
            var outline = new Outline();
            var cubeTransform = cube.GetComponent<Transform>();
            var position = new Vector3(cubeTransform.position);
            var transform = new Matrix4
                (
                cubeTransform.transform.Row0,
                cubeTransform.transform.Row1,
                cubeTransform.transform.Row2,
                cubeTransform.transform.Row3
                );
            outline.AddComponent(new Transform(position, transform));
            outline.AddComponent(OutlineMeshCreator.CreateCubeOutlineMesh(cube));
            outline.AddComponent(new RenderProps(_fragShaderPath, _vertShaderPath, null, OpenTK.Graphics.OpenGL.PrimitiveType.Lines, 2.0f));
            outline.AddComponent(new MeshRenderer());
            outline.GetComponent<MeshRenderer>().Init();
            return outline;
        }
    }  
}
