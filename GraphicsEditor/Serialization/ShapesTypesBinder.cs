using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Serialization
{
    class ShapesTypesBinder : SerializationBinder
    {

        private static ShapesTypesBinder instance;

        private ShapesTypesBinder()
        {

        }

        public static ShapesTypesBinder getInstance()
        {
            if (instance == null)
                instance = new ShapesTypesBinder();
            return instance;
        }

        public override Type BindToType(
            string assemblyName,
            string typeName)
        {
            string[] typeInfo = typeName.Split('.');

            //The latest item is the class name
            string className = typeInfo[typeInfo.Length - 1];

            foreach(var entry in Editor.getInstance().Settings.ShapeTypesInfoMap)
            {
                if(className == entry.Key)
                {
                    return Editor.getInstance().Settings.ShapeTypesInfoMap[className].Creator.Create(null, System.Drawing.Color.Black).GetType();
                }
            }

            return Type.GetType(
                string.Format("{0}, {1}",
                typeName, 
                assemblyName));
        }

    }
}
