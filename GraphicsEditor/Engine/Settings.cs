using System.Collections.Generic;
using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeRenderers;

namespace GraphicsEditor.Engine
{
    class Settings
    {
        class ShapeTypeInfo
        {
            public IShapeRenderer Renderer { get; set; }


        }

        public List<IShapeRenderer> ShapeRenderers { get; set; }

        private Dictionary<string, ShapeTypeInfo> shapeTypesInfoMap;

        public Settings()
        {
            shapeTypesInfoMap = new Dictionary<string, ShapeTypeInfo>();

            Reset();
        }

        public void Reset()
        {
            shapeTypesInfoMap.Clear();

            SetRendererForShapeType(typeof(Line).Name, StandardLineRenderer.getInstance());
            SetRendererForShapeType(typeof(Rectangle).Name, StandardRectangleRenderer.getInstance());
            SetRendererForShapeType(typeof(Square).Name, StandardRectangleRenderer.getInstance());
            SetRendererForShapeType(typeof(Ellipse).Name, StandardEllipseRenderer.getInstance());
            SetRendererForShapeType(typeof(Circle).Name, StandardEllipseRenderer.getInstance());
            SetRendererForShapeType(typeof(Triangle).Name, StandardTriangleRenderer.getInstance());
        }

        public void SetRendererForShapeType(string shapeTypeName, IShapeRenderer shapeRenderer)
        {
            shapeTypesInfoMap[shapeTypeName].Renderer = shapeRenderer;
        }

        public IShapeRenderer GetRendererForShapeType(string shapeTypeName)
        {
            if(shapeTypesInfoMap.ContainsKey(shapeTypeName))
            {
                return shapeTypesInfoMap[shapeTypeName].Renderer;
            }
            else
            {
                return null;
            }
        }
    }
}
