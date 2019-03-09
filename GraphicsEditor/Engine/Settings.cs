using System.Collections.Generic;
using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeRenderers;

namespace GraphicsEditor.Engine
{
    class Settings
    {
        private Dictionary<System.Guid, IShapeRenderer> shapeRenderers;

        public Settings()
        {
            shapeRenderers = new Dictionary<System.Guid, IShapeRenderer>();

            Reset();
        }

        public void Reset()
        {
            shapeRenderers.Clear();

            SetRendererForShapeType(typeof(Line).GUID, StandardLineRenderer.getInstance());
            SetRendererForShapeType(typeof(Rectangle).GUID, StandardRectangleRenderer.getInstance());
            SetRendererForShapeType(typeof(Square).GUID, StandardRectangleRenderer.getInstance());
            SetRendererForShapeType(typeof(Ellipse).GUID, StandardEllipseRenderer.getInstance());
            SetRendererForShapeType(typeof(Circle).GUID, StandardEllipseRenderer.getInstance());
            SetRendererForShapeType(typeof(Triangle).GUID, StandardTriangleRenderer.getInstance());
        }

        public void SetRendererForShapeType(System.Guid shapeTypeGuid, IShapeRenderer shapeRenderer)
        {
            shapeRenderers[shapeTypeGuid] = shapeRenderer;
        }

        public IShapeRenderer GetRendererForShapeType(System.Guid shapeTypeGuid)
        {
            if(shapeRenderers.ContainsKey(shapeTypeGuid))
            {
                return shapeRenderers[shapeTypeGuid];
            }
            else
            {
                return null;
            }
        }
    }
}
