﻿using DeltaEngine.Platforms;

namespace TinyPlatformer
{
	/// <summary>
	/// Begin a new game
	/// </summary>
	internal class Program : App
	{
		public Program()
		{
			new Game(new Map());
		}

		public static void Main()
		{
			new Program().Run();
		}
	}
}