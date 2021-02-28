using System;
using System.Collections.Generic;
using static Note.Manager;
using static Utility.Helper;

namespace NotesSotre
{
	internal class NotesSotre
	{
		public string Name { get; set; }
		public State State;

		private DateTime DateTime;

		public static List<string> names = new List<string>();

		private bool isNew = true;

		public static int Count{ get => names.Count; }

		public NotesSotre(string name, State state)
		{
			this.State = state;
			this.Name = name;
			this.DateTime = DateTime.Now;
			names.Add(name);
			this.isNew = true;
		}

		public void AddNote(State state)
		{
			switch (state)
			{
				case State.None:
					Console.WriteLine("No State!");
					break;
				case State.completed:
					{
						bool flag = this.isNew;
						if (flag)
						{
							Add(this.Name, this.State, this.DateTime);
							this.isNew = false;
						}
						else
						{
							Console.WriteLine("Sorry your state is a completed");
						}
						break;
					}
				case State.active:
					Add(this.Name, this.State, this.DateTime);
					Console.WriteLine("Well done!");
					break;
				case State.others:
					Add(this.Name, this.State, this.DateTime);
					Console.WriteLine("Well done!");
					break;
			}
		}

		public static void GetNotes(State state)
		{
			List<string> list = GetNotesWithState(state, names);
			foreach (string item in list)
			{
				Console.WriteLine(string.Format("The {0} note state is {1}", item, state));
			}
		}

		public static void GetActiveNotes()
		{
			Console.WriteLine(string.Format("The Active state notes count is {0}", GetNotesWithState(State.active, names).Count));
		}

		public static void GetCompletedNotes()
		{
			Console.WriteLine(string.Format("The Completed state notes count is {0}", GetNotesWithState(State.completed, names).Count));
		}

		
	}
}
