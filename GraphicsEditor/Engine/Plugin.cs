using System;
using System.Collections.Generic;

namespace GraphicsEditor.Engine
{
    interface IPlugin
    {
        string Name();

        string Description();

        void Process(byte[] data);

        void Tune(Dictionary<String, String> settings);

        Dictionary<String, List<String>> GetParameters();
    }
}
