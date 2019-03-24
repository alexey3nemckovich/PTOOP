using System.Collections.Generic;

namespace GraphicsEditor.Engine
{
    public delegate object ParameterValueParser(string text);
    public delegate string ParameterValuePresentator(object value);

    public class PluginParameterInfo
    {
        public string Name { get; private set; }
        public bool IsEnum { get; private set; }
        public object Value { get; private set; }
        public HashSet<string> PossibleValues { get; private set; }
        public ParameterValueParser Parser { get; private set; }
        public ParameterValuePresentator Presentator { get; private set; }

        public PluginParameterInfo(string name, ParameterValueParser parseParameterDelegate, ParameterValuePresentator valuePresentator, object value)
        {
            IsEnum = false;

            Parser = parseParameterDelegate;
            Presentator = valuePresentator;
            Name = name;
            
            Value = value;
        }

        public PluginParameterInfo(string name, ParameterValueParser parseParameterDelegate, ParameterValuePresentator valuePresentator, HashSet<string> possibleValues, object value)
        {
            IsEnum = true;

            Parser = parseParameterDelegate;
            Presentator = valuePresentator;
            Name = name;
            
            PossibleValues = possibleValues;
            Value = value;
        }

        public void SetValue(object value)
        {
            Value = value;
        }

        public string GetValueStringRepresentation()
        {
            return Presentator(Value);
        }
    }
}
