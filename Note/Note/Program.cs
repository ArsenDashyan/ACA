using System;
using static Utility.Helper;

namespace NotesSotre
{
    class Program
    {
        static void Main(string[] args)
        {
			NotesSotre note5 = new NotesSotre("HomeWork", State.active);

			NotesSotre note6 = new NotesSotre("Contatcts", State.completed);
			note6.AddNote(State.completed);
			note6.AddNote(State.completed);

			NotesSotre note7 = new NotesSotre("Like", State.others);
			NotesSotre note8 = new NotesSotre("NewContatcts", State.completed);

			NotesSotre.GetActiveNotes();
			NotesSotre.GetCompletedNotes();
			NotesSotre.GetNotes(State.completed);
			Console.WriteLine(NotesSotre.Count);

			Console.ReadLine();
		}
    }
}
