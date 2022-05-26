using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Service.Services;
using MockQueryable.NSubstitute;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Banding.Tests.Services
{
    public class ValidationServiceTests
    {
        [Fact]
        public void IsEmailOrUsernameRepeatedTest()
        {
            #region Arrage
            var expected = true;
            var email = "alan4630@gmail.com";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var returnList = new List<Usuario> {
                new Usuario
                {
                    EMail = "alan4630@gmail.com",
                    Username = "alanjuker",
                },
                new Usuario
                {
                    EMail = "jacknarv@gmail.com",
                    Username = "alanjuker",
                },
                 new Usuario
                {
                    EMail = "bsflores@gmail.com",
                    Username = "alanjuker",
                }};
            usuarioRepository.GetUsuarios().Returns(returnList);
            var _validationService = new ValidationService(usuarioRepository);

            #endregion

            #region Act
            var actual = _validationService.isEmailorUsernameRepeated(email);
            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }
        [Fact]
        public void IsEmailOrUsernameRepeatedTest2()
        {
            #region Arrage
            var expected = false;
            var email = "mateoalarcon@gmail.com";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var returnList = new List<Usuario> {
                new Usuario
                {
                    EMail = "alan4630@gmail.com",
                    Username = "alanjuker",
                },
                new Usuario
                {
                    EMail = "jacknarv@gmail.com",
                    Username = "alanjuker",
                },
                 new Usuario
                {
                    EMail = "bsflores@gmail.com",
                    Username = "alanjuker",
                }};
            usuarioRepository.GetUsuarios().Returns(returnList);
            var _validationService = new ValidationService(usuarioRepository);

            #endregion

            #region Act
            var actual = _validationService.isEmailorUsernameRepeated(email);
            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }
        [Fact]
        public void ValidateCedulaTest()
        {
            #region Arrage
            var expected = true;
            var cedula = "0605167402";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var _validationService = new ValidationService(usuarioRepository);


            #endregion

            #region Act
            var actual = _validationService.ValidateCedula(cedula);
            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }
        [Fact]
        public void ValidateCedulaTest2()
        {
            #region Arrage
            var expected = false;
            var cedula = "0607167402";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var _validationService = new ValidationService(usuarioRepository);

            #endregion

            #region Act
            var actual = _validationService.ValidateCedula(cedula);

            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }
        [Fact]
        public void ValidateEmailTest1()
        {
            #region Arrage
            var expected = true;
            var email = "alan6430@gmail.com";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var _validationService = new ValidationService(usuarioRepository);
            #endregion

            #region Act
            var actual = _validationService.ValidateEmail(email);

            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }
        [Fact]
        public void ValidateEmailTest2()
        {
            #region Arrage
            var expected = false;
            var email = "s@h.com";
            var usuarioRepository = Substitute.For<IUsuarioRepository>();
            var _validationService = new ValidationService(usuarioRepository);
            #endregion

            #region Act
            var actual = _validationService.ValidateEmail(email);

            #endregion

            #region Assert
            Assert.Equal(expected, actual);
            #endregion
        }

    }
}
