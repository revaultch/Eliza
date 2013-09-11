// <copyright file="Test.cs" company="takoyaki.ch">
// Copyright (c) 2013, All Right Reserved, http://takoyaki.ch
// </copyright>
// <author>Urs Keller</author>
// <email><urs@takoyaki.ch</email>
// <date>07/20/2013</date>
// <summary></summary>
//
using System;
using NUnit.Framework;

namespace Eliza.Test
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase ()
		{
			ElizaMain eliza = new ElizaMain();

			foreach (var s in new string[] {"Hello", "Well, and you?", "I'm implementing some weird project.", "Yes, can you give me technical advice?", "Thank you.", "Bye."}) {
				Console.WriteLine("> {0}", s);
				Console.WriteLine("< {0}", eliza.ProcessInput(s));
			}

		}
	}
}

