namespace GraphicsEditor.Engine
{
    class Editor
    {
        private static Editor instance;

        private Editor()
        {
            Reset();
        }

        public static Editor getInstance()
        {
            if (instance == null)
                instance = new Editor();
            return instance;
        }

        public Settings Settings { get; set; }
        public ListOfShapes ListOfShapes { get; set; }

        public void Reset()
        {
            Settings.Reset();
            ListOfShapes.Clear();
        }
    }
}
