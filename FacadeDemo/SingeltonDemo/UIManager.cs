namespace SingeltonDemo {
    internal class UiManager {
        private static UiManager instance;

        private UiManager() {}

        public static UiManager Instance {
            get {
                if (instance.Equals(null))
                {
                    instance = new UiManager();
                }
                return instance;
            }
        }
    }
}