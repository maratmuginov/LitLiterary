using System;
using System.Threading.Tasks;
using LitLiteracy.Tests.Mocks;
using LitLiterary.Lib.Shared.Contracts.Services;
using LitLiterary.Lib.Shared.Models;
using NUnit.Framework;

namespace LitLiteracy.Tests.Services
{
    public class RepositoryTests
    {
        private readonly IRepository<Guid, DomainObject> _repository;

        public RepositoryTests()
        {
            _repository = new MockLibraryRepository();
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public async Task CanDomainObjectBeAdded()
        {
            var domainObject = new DomainObject();
            await _repository.CreateAsync(domainObject);
            Assert.True(domainObject.Id != default);
        }
    }
}
