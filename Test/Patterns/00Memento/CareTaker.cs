namespace Test.patterns.Memento
{
    public class Caretaker
    {
        List<Memento> mementos;
        public Caretaker()
        {
            mementos = new List<Memento>();
        }
        private int memCount
        {
            get { return mementos.Count; }
        }
        public void CreateBackup(Memento memento)
        {
            mementos.Add(memento);
            Console.WriteLine("Created backup at " + memento.LastUpdateDate);
        }

        public Memento Restore()
        {
            if (memCount == 0) return new Memento("", "");
            var memento = mementos[memCount - 1];
            mementos.RemoveAt(memCount - 1);
            return memento;
        }
    }
}