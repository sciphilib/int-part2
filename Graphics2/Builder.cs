
namespace Graphics2
{
    public abstract class Builder
    {
        protected string _fragShaderPath;
        protected string _vertShaderPath;

        public Builder(string fragShaderPath, string vertShaderPath)
        {
            _fragShaderPath = fragShaderPath;
            _vertShaderPath = vertShaderPath;
        }
    }
}
