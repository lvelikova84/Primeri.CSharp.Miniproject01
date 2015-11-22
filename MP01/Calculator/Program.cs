using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput = new UserInput.UInput ();


		public static void Main (string[] args)
		{

			MainClass _program = new MainClass ();		//предефинираме нашата програма

			_program.uInput.getUsrecommands ();				//достъпваме нашата библиотека
		}
	}
}
