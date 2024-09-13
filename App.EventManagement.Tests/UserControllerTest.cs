using App.EventManagement.API.Controllers;
using App.EventManagement.Application.Features.Query.GetAllRquest;
using App.EventManagement.Application.Features.Query.GetById;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;

namespace App.EventManagement.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IMediator> _mockRepo;
      
        private readonly ServiceRequestController _controller;
       
        public UnitTest1()
        {

            _mockRepo = new Mock<IMediator>();
           
            _controller = new ServiceRequestController(_mockRepo.Object);
        }

        [TestMethod]
        public void GetById_Success()
        {
            GetByIdRquest loginByUserName = new GetByIdRquest();
            loginByUserName.Id = Guid.NewGuid();
            var result = _controller.GetById(Guid.NewGuid(), CancellationToken.None);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetByAll_Success()
        {
            GetAllRquest allRquest= new GetAllRquest();
            allRquest.PageNumber = 1;
            allRquest.PageSize = 10;    
            var result = _controller.GetAll( CancellationToken.None);
            Assert.IsNotNull(result);
        }
    }
}