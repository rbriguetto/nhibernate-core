﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NHibernate.Test.MultipleCollectionFetchTest
{
	using System.Threading.Tasks;
	[TestFixture]
	public class MultipleListFetchFixtureAsync : AbstractMultipleCollectionFetchFixtureAsync
	{
		protected override string[] Mappings
		{
			get { return new string[] { "MultipleCollectionFetchTest.PersonList.hbm.xml" }; }
		}

		protected override void AddToCollection(ICollection<Person> persons, Person person)
		{
			((List<Person>) persons).Add(person);
		}

		protected override ICollection<Person> CreateCollection()
		{
			return new List<Person>();
		}
	}
}
