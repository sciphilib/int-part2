using Graphics2.ECS;
using OpenTK.Graphics.OpenGL;


namespace Graphics2
{
    public class RenderProps : Component
    {
        public string _vertexShaderPath;
        public string _fragmentShaderPath;
        public double[]? _verticesColorArray;
        public Shader _shader;
        public PrimitiveType _primitiveType;
        public float _lineWidth;

        public RenderProps(string fragmentShaderPath, string vertexShaderPath, double[]? color, PrimitiveType pType, float lineWidth = 2.0f)
        {
            _fragmentShaderPath = fragmentShaderPath;
            _vertexShaderPath = vertexShaderPath;
            _shader = new(_vertexShaderPath, _fragmentShaderPath);
            _verticesColorArray = color;
            _primitiveType = pType;
            _lineWidth = lineWidth;
        }
    }
}
