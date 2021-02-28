using System;
using System.Collections.Generic;
using System.IO;
using static Utility.Helper;

namespace Note
{
	public class Manager
	{
		private static string filepath = "C:\\Users\\arsen\\OneDrive\\Desktop\\Notes\\";
		public static void Add(string name, State state, DateTime dateTime)
		{
			string details = string.Format("{0}:{1}:{2}", name, state, dateTime);
			Console.WriteLine("Please input your note");
			string input = Console.ReadLine();
			bool flag = !File.Exists(filepath + name + ".txt");
			if (flag)
			{
				File.Create(filepath + name + ".txt").Close();
				File.WriteAllText(filepath + name + ".txt", details);
			}
			File.AppendAllText(filepath + name + ".txt", "\n" + input);
		}

		public static List<string> GetNotesWithState(State state, List<string> array)
		{
			List<string> result = new List<string>();
			foreach (string name in array)
			{
				using (File.OpenText(filepath + name + ".txt"))
				{ 
					string[] firstline = File.ReadAllLines(filepath + name + ".txt");
					string[] fileState = firstline[0].Split(':', StringSplitOptions.None);
					bool flag = fileState[1] == state.ToString();
					if (flag)
					{
						result.Add(name);
					}
				}
			}
			return result;
		}
	}
}
