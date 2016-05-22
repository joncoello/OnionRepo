using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnionRepo.SqlRepositories;
using System.Linq;

namespace OnionRepo.SqlRepositoriesTests {

    [TestClass]
    public class ContactRepositoryTests {

        [TestMethod]
        public void ContactRepository_Find() {

            var sut = new ContactRepository();
            var results = sut.GetContacts();
            Assert.IsTrue(results.Count() > 0);

        }

    }

}
