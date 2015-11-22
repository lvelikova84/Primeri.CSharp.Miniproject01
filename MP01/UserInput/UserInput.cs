using System;

namespace UserInput
{
	public class UInput
	{
		public UInput ()
		{
		}

		public void getUsrecommands ()
		{
			string _command = "";

			do {
				//Взимане на команда
				Console.Write ("$ ");
				_command = Console.ReadLine ();

				//Проверка за налични команди
				if (_command.ToLower().Contains ("команда1"))		Console.WriteLine ("Стартирана е Команда 1\n");
				if (_command.ToLower().Contains ("команда2"))		Console.WriteLine ("Стартирана е Команда 2\n");
				if (_command.ToLower().Contains ("команда3"))		Console.WriteLine ("Стартирана е Команда 3\n");



			} while (_command.ToLower() != "изход");

		}


		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.justTesting ()");
		}
	}
}

