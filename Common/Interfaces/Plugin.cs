using System;
using System.Collections.Generic;
using GraphicsEditor.Serialization;

namespace GraphicsEditor.Engine
{
    public abstract class Plugin
    {
        public Plugin()
        {
            ParametersInfo = new Dictionary<string, PluginParameterInfo>();
        }

        public abstract string Name();

        public abstract string Description();

        public abstract int Order();

        public abstract byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data);

        public abstract byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data);

        public bool Tune(Dictionary<string, string> settings)
        {
            Dictionary<string, object> parsedParametersValues = new Dictionary<string, object>();

            foreach(var paramInfoEntry in ParametersInfo)
            {
                object value = null;

                if(!TryParseParameterValue(paramInfoEntry.Value.Parser, settings[paramInfoEntry.Key], ref value))
                {
                    return false;
                }
                else
                {
                    parsedParametersValues[paramInfoEntry.Key] = value;
                }
            }

            foreach(var paramParsedValueEntry in parsedParametersValues)
            {
                ParametersInfo[paramParsedValueEntry.Key].SetValue(paramParsedValueEntry.Value); 
            }

            return true;
        }

        private bool TryParseParameterValue(ParameterValueParser parser, string valueStr, ref object value)
        {
            try
            {
                value = parser(valueStr);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Dictionary<string, PluginParameterInfo> ParametersInfo { get; protected set; }

        private static ParameterValuePresentator defaultParameterValuePresentator = delegate (object value)
                                                                                    {
                                                                                        return value.ToString();
                                                                                    };

        protected void RegisterParameter(string paramName, object value, ParameterValueParser parseParameterDelegate, ParameterValuePresentator valuePresentator = null)
        {
            if(null == valuePresentator)
            {
                valuePresentator = defaultParameterValuePresentator;
            }

            ParametersInfo.Add(paramName, new PluginParameterInfo(paramName, parseParameterDelegate, valuePresentator, value));
        }

        protected void RegisterParameter(string paramName, object value, HashSet<string> possibleValues, ParameterValueParser parseParameterDelegate, ParameterValuePresentator valuePresentator = null)
        {
            if (null == valuePresentator)
            {
                valuePresentator = defaultParameterValuePresentator;
            }

            ParametersInfo.Add(paramName, new PluginParameterInfo(paramName, parseParameterDelegate, valuePresentator, possibleValues, value));
        }
    }
}
