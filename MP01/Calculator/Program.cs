﻿using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput = new UserInput.UInput ();
		public About.Me about = new About.Me ();

		public static void Main (string[] args)
		{

			MainClass _program = new MainClass ();		//предефинираме нашата програма

			//форматиране на програмата
			Console.Title = _program.about.shortName + ", " + _program.about.version;

			//Стартиране на програмата
			_program.uInput.sayHello ();
			_program.uInput.getUsrecommands ();				//достъпваме нашата библиотека
		}
	}
}
