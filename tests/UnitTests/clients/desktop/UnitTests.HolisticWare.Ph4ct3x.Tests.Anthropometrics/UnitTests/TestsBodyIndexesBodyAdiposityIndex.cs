﻿using NUnit.Framework;
using System;

namespace UnitTests.HolisticWare.Ph4ct3x.Tests.Anthropometrics
{
	[TestFixture ()]
	public class TestsBodyIndexesBodyAdiposityIndex
	{
		// http://en.wikipedia.org/wiki/Body_adiposity_index

		[SetUp]
		public void Setup ()
		{
		}

		
		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Pass ()
		{
			Console.WriteLine ("test1");
			Assert.True (true);
		}

		[Test]
		public void Fail ()
		{
			Assert.False (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}

		[Test]
		public void Inconclusive ()
		{
			Assert.Inconclusive ("Inconclusive");
		}
	}
}

