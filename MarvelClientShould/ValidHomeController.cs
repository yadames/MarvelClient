using MarvelClient.Controllers;
using MarvelClient.Models;
using MarvelClient.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarvelClientShould
{
    public class ValidHomeController : BaseUnitTestClass
    {
        private HomeController _controller;

        public ValidHomeController() : base()
        {
            IStringLocalizer<HomeController> _stringLocalizer = _serviceProvider.GetService<IStringLocalizer<HomeController>>();
            IMarvelService _marvelService = _serviceProvider.GetService<IMarvelService>();
            _controller = new HomeController(_stringLocalizer, _marvelService);
        }

        [Fact]
        public async Task Validate_EmptyParameter()
        {
            //Arrange

            //Act
            ViewResult result = await _controller.Index("") as ViewResult;

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Validate_ParameterIsANumber()
        {
            //Arrange

            //Act
            ViewResult result = await _controller.Index("123") as ViewResult;

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Validate_ParameterIsNotANumber()
        {
            //Arrange

            //Act
            ViewResult result = await _controller.Index("asd") as ViewResult;

            //Assert
            Assert.IsType<ViewResult>(result);
            Assert.IsType<string>(result.ViewData["ErrorMessage"]);
        }

        [Fact]
        public async Task Validate_FindHeroWithInvalidId()
        {
            //Arrange

            //Act
            ViewResult result = await _controller.Index("123") as ViewResult;

            //Assert
            Assert.IsType<ViewResult>(result);
            Assert.IsType<string>(result.ViewData["ErrorMessage"]);
        }

        [Fact]
        public async Task Validate_FindHeroWithValidId()
        {
            //Arrange

            //Act
            ViewResult result = await _controller.Index("1009351") as ViewResult;
            Hero hero = result.Model as Hero;

            //Assert
            Assert.IsType<ViewResult>(result);
            Assert.IsType<Hero>(result.Model);
            Assert.Equal("Hulk", (result.Model as Hero).Data.Results.FirstOrDefault().Name);
        }
    }
}
