using MarvelClient.Controllers;
using MarvelClient.Repository.Contract;
using MarvelClient.Service;
using Microsoft.Extensions.Localization;
using Xunit;

namespace MarvelClientShould
{
    public class ValidDependencyInjection : BaseUnitTestClass
    {
        public ValidDependencyInjection() : base() { }

        [Fact]
        public void Validate_IStringLocalizerNotNull()
        {
            //Arrange
            IStringLocalizer<HomeController> _stringLocalizer = _serviceProvider.GetService<IStringLocalizer<HomeController>>();

            //Act

            //Assert
            Assert.NotNull(_stringLocalizer);
        }

        [Fact]
        public void Validate_IMarvelServiceNotNull()
        {
            //Arrange
            IMarvelService _marvelService = _serviceProvider.GetService<IMarvelService>();

            //Act

            //Assert
            Assert.NotNull(_marvelService);
        }

        [Fact]
        public void Validate_IRepositoryNotNull()
        {
            //Arrange
            IRepository _repository = _serviceProvider.GetService<IRepository>();

            //Act

            //Assert
            Assert.NotNull(_repository);
        }
    }
}
