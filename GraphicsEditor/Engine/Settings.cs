using System.Collections.Generic;
using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeRenderers;
using GraphicsEditor.ShapeCreators;

namespace GraphicsEditor.Engine
{
    class Settings
    {
        class ShapeTypeInfo
        {
            public ShapeTypeInfo(IShapeCreator creator, IShapeRenderer renderer)
            {
                this.Creator = creator;
                this.Renderer = renderer;
            }

            public IShapeCreator Creator { get; set; }

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

            RegisterShapeType(LineCreator.getInstance(), StandardLineRenderer.getInstance());
            RegisterShapeType(RectangleCreator.getInstance(), StandardRectangleRenderer.getInstance());
            RegisterShapeType(SquareCreator.getInstance(), StandardRectangleRenderer.getInstance());
            RegisterShapeType(EllipseCreator.getInstance(), StandardEllipseRenderer.getInstance());
            RegisterShapeType(CircleCreator.getInstance(), StandardEllipseRenderer.getInstance());
            RegisterShapeType(TriangleCreator.getInstance(), StandardTriangleRenderer.getInstance());
        }

        public void SetRendererForShapeType(string shapeTypeName, IShapeRenderer shapeRenderer)
        {
            shapeTypesInfoMap[shapeTypeName].Renderer = shapeRenderer;
        }

        public void RegisterShapeType(IShapeCreator creator)
        {
            shapeTypesInfoMap[creator.ShapeTypeName()] = new ShapeTypeInfo(creator, null);
        }

        public void RegisterShapeType(IShapeCreator creator, IShapeRenderer renderer)
        {
            shapeTypesInfoMap[creator.ShapeTypeName()] = new ShapeTypeInfo(creator, renderer);
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
