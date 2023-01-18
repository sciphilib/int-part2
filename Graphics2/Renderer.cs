﻿using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;

namespace Graphics2
{

    public class Renderer
    {
        private readonly GameWindow _window;
        private bool IsMeshMode = false;
        private Camera _camera;
        private CameraContext _cameraContext;

        public MainScene mainScene;


        public Renderer(Window window)
        {
            _window = window;
            OnLoad();
            window.BindRenderCallback(OnRender);
            window.BindDrawGUICallback(OnImGuiDraw);
        }

        ~Renderer()
        {
            OnUnload();
        }
        private void OnLoad()
        {
            _camera = new(new Vector3(-3.0f, 1.0f, 5.0f), new Vector3(0.0f, 0.0f, 0.0f), (float)_window.Size.X / _window.Size.Y);
            _cameraContext = new(_camera);

            mainScene = new();

            IsMeshMode = false;
            GL.ClearColor(new Color4(0.5f, 0.5f, 0.5f, 1.0f));
        }

        private void OnRender()
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);
            GL.PolygonMode(MaterialFace.FrontAndBack, IsMeshMode ? PolygonMode.Line : PolygonMode.Fill);

            _cameraContext.Update();
            SceneRenderer.Render(mainScene, _cameraContext);

        }

        private void OnImGuiDraw()
        {
            
        }
        private void OnUnload()
        {

        }

        public void ChangeMeshMode()
        {
            IsMeshMode = !IsMeshMode;
        }

        public Camera GetCamera()
        {
            return _camera;
        }
    }
}
