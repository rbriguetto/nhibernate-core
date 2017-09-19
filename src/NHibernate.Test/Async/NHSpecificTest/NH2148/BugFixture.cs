﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using NUnit.Framework;

namespace NHibernate.Test.NHSpecificTest.NH2148
{
	using System.Threading.Tasks;
	[TestFixture]
	public class BugFixtureAsync : BugTestCase
	{
		protected override void OnSetUp()
		{
			using (var s = OpenSession())
			using (var tx = s.BeginTransaction())
			{
				s.Persist(new Book
				{
					Id = 1,
					ALotOfText = "a lot of text ..."
				});
				tx.Commit();
			}

		}

		protected override void OnTearDown()
		{
			using (var s = OpenSession())
			using (var tx = s.BeginTransaction())
			{
				Assert.That(s.CreateSQLQuery("delete from Book").ExecuteUpdate(), Is.EqualTo(1));
				tx.Commit();
			}
		}

		[Test]
		public async Task CanCallLazyPropertyEntityMethodAsync()
		{
			using (ISession s = OpenSession())
			{
				var book = await (s.GetAsync<Book>(1)) as IBook;

				Assert.IsNotNull(book);

				string s1 = "testing1";
				string s2 = book.SomeMethod(s1);
				Assert.AreEqual(s1, s2);
			}
		}
	}
}