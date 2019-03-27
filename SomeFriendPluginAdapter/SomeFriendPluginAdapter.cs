using SomeFriendPlugin;
using GraphicsEditor.Engine;
using GraphicsEditor.Serialization;

namespace SomeFriendPluginAdapter
{
    public class SomeFriendPluginAdapter : Plugin
    {
        FriendPlugin friendPlugin = new FriendPlugin();

        private static string friendPluginMessageOnSaveParamName = "Friend plugin message on save";
        private static string friendPluginMessageOnLoadParamName = "Friend plugin message on load";

        public SomeFriendPluginAdapter()
        {
            RegisterParameter(
                friendPluginMessageOnSaveParamName,
                "",
                delegate (string strValue)
                {
                    return strValue;
                });

            RegisterParameter(
                friendPluginMessageOnLoadParamName,
                "",
                delegate (string strValue)
                {
                    return strValue;
                });
        }

        public override string Name()
        {
            return "SomeFriendPlugin adaptered";
        }

        public override string Description()
        {
            return "Shows message on save/load";
        }

        public override int Order()
        {
            return 3;
        }

        public override byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data)
        {
            friendPlugin.DoSave(
                (string)ParametersInfo[friendPluginMessageOnSaveParamName].Value);

            return data;
        }

        public override byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data)
        {
            friendPlugin.DoLoad(
                (string)ParametersInfo[friendPluginMessageOnLoadParamName].Value);

            return data;
        }

    }
}
