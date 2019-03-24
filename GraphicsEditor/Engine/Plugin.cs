using System.Collections.Generic;

namespace GraphicsEditor.Engine
{
    interface IPlugin
    {
        string Name();

        string Description();

        void Process(byte[] data);

        void Tune(Dictionary<string, string> settings);

        Dictionary<string, List<string>> GetParameters();
    }
}
