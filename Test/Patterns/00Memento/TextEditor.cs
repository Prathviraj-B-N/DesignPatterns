// You’re building a text editor that allows users to type text and undo changes.
// The editor should let the user add text.
// It should allow the user to save the current state of the text.
// The user should be able to undo (restore the last saved state).
// Implement this using the Memento Pattern(with Originator, Memento, and Caretaker).

namespace Test.patterns.Memento
{
    class TextEditor
    {
        private string _title;
        private string _body;
        private readonly Caretaker _caretaker;
        public TextEditor(Caretaker caretaker)
        {
            _title = "";
            _body = "";
            _caretaker = caretaker;
        }

        public void Type(string text)
        {
            _body += text;
        }
        public void SetTitle(string title)
        {
            _title = title;
        }

        public void save()
        {
            _caretaker.CreateBackup(new Memento(_title, _body));
        }

        public void Undo()
        {
            Console.WriteLine($"Reverted from \n{this.ToString()}");
            var prevSavedState = _caretaker.Restore();
            this._title = prevSavedState.title;
            this._body = prevSavedState.body;
            Console.WriteLine($"To\n{this.ToString()}");
        }
        public override string ToString()
        {
            return $"Title: {_title}\nBody: {_body}";
        }
    }
}