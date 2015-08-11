using System;

namespace Bug32417
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var x = new AwesomeClass ();
			var y = new SuperAwesomeClass ();
			y.Super = "Mr Incredible";

			Console.WriteLine(y.Super);
		}
	}
}
