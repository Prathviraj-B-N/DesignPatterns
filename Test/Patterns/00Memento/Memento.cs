namespace Test.patterns.Memento
{
    // how does it handle fopr multiple user?
    public class Memento
    {
        public string title{ get; private set; }
        public string body{ get; private set; }

        public DateTime LastUpdateDate{ get; private set; }


        public Memento(string title, string body)
        {
            this.title = title;
            this.body = body;
            this.LastUpdateDate = DateTime.Now;
        }
    }
}