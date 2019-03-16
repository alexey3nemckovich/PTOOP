using System.Collections.Generic;
using GraphicsEditor.ShapeRenderers;
using GraphicsEditor.ShapeCreators;

namespace GraphicsEditor.Engine
{
    class Settings
    {
        public class ShapeTypeInfo
        {
            public ShapeTypeInfo(IShapeCreator creator, IShapeRenderer renderer)
            {
                this.Creator = creator;
                this.Renderers = new Dictionary<string, IShapeRenderer>();

                if(null != renderer)
                {
                    this.Renderers.Add(renderer.Name(), renderer);
                    this.Renderer = renderer;
                }
            }

            public IShapeCreator Creator { get; set; }

            public IShapeRenderer Renderer { get; set; }

            public Dictionary<string, IShapeRenderer> Renderers { get; private set; }
        }

        public List<IShapeRenderer> ShapeRenderers { get; set; }

        public Dictionary<string, ShapeTypeInfo> ShapeTypesInfoMap { get; private set; }

        public Settings()
        {
            ShapeTypesInfoMap = new Dictionary<string, ShapeTypeInfo>();

            Reset();
        }

        public void Reset()
        {
            ShapeTypesInfoMap.Clear();

            RegisterShapeType(LineCreator.getInstance(), StandardLineRenderer.getInstance());
            RegisterShapeType(RectangleCreator.getInstance(), StandardRectangleRenderer.getInstance());
            RegisterShapeType(SquareCreator.getInstance(), StandardRectangleRenderer.getInstance());
            RegisterShapeType(EllipseCreator.getInstance(), StandardEllipseRenderer.getInstance());
            RegisterShapeType(CircleCreator.getInstance(), StandardEllipseRenderer.getInstance());
            RegisterShapeType(TriangleCreator.getInstance(), StandardTriangleRenderer.getInstance());
        }

        public void RegisterShapeType(IShapeCreator creator)
        {
            ShapeTypesInfoMap[creator.ShapeTypeName()] = new ShapeTypeInfo(creator, null);
        }

        public void RegisterShapeType(IShapeCreator creator, IShapeRenderer renderer)
        {
            ShapeTypesInfoMap[creator.ShapeTypeName()] = new ShapeTypeInfo(creator, renderer);

            //if(!ShapeTypesInfoMap[creator.ShapeTypeName()].Renderers.ContainsKey(StandardLineRenderer.getInstance().Name()))
            //{
            //    ShapeTypesInfoMap[creator.ShapeTypeName()].Renderers.Add(StandardLineRenderer.getInstance().Name(), StandardLineRenderer.getInstance());
            //}
        }

        public void RegisterShapeTypeRenderer(IShapeRenderer renderer)
        {
            ShapeTypesInfoMap[renderer.RenderingShapeTypeName()].Renderers.Add(renderer.Name(), renderer);

            if(null == ShapeTypesInfoMap[renderer.RenderingShapeTypeName()].Renderer)
            {
                ShapeTypesInfoMap[renderer.RenderingShapeTypeName()].Renderer = renderer;
            }
        }

        public void SetRendererForShapeType(string shapeTypeName, IShapeRenderer shapeRenderer)
        {
            ShapeTypesInfoMap[shapeTypeName].Renderer = shapeRenderer;
        }

        public IShapeRenderer GetCurrentRendererForShapeType(string shapeTypeName)
        {
            if(ShapeTypesInfoMap.ContainsKey(shapeTypeName))
            {
                return ShapeTypesInfoMap[shapeTypeName].Renderer;
            }
            else
            {
                return null;
            }
        }

        public IShapeRenderer GetRendererForShapeType(string shapeTypeName, string rendererName)
        {
            if (ShapeTypesInfoMap.ContainsKey(shapeTypeName))
            {
                if(ShapeTypesInfoMap[shapeTypeName].Renderers.ContainsKey(rendererName))
                {
                    return ShapeTypesInfoMap[shapeTypeName].Renderers[rendererName];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public IShapeCreator GetCreatorForShapeType(string shapeTypeName)
        {
            if (ShapeTypesInfoMap.ContainsKey(shapeTypeName))
            {
                return ShapeTypesInfoMap[shapeTypeName].Creator;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetRenderableShapeTypesNames()
        {
            List<string> list = new List<string>();

            foreach(var entry in ShapeTypesInfoMap)
            {
                if(null != entry.Value.Renderer)
                {
                    list.Add(entry.Key);
                }
            }

            return list;
        }

        public List<string> GetRegisteredShapeTypesNames()
        {
            return new List<string>(ShapeTypesInfoMap.Keys);
        }
    }
}
