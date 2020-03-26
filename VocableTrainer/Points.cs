namespace VocableTrainer
{
    public class Points
    {
        public int Right { get; protected set; } = 0;
        private static Points instance;
        private Points() { }
        public static Points GetInstance()
        {
            if (instance == null)
            {
                instance = new Points();
            }
            return instance;
        }
        public void AnswerIsRight()
        {
            instance.Right += 1;
        }

        public void Reset()
        {
            instance.Right = 0;
        }
    }
}
