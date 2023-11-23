

namespace ApiTests.Controllers;

public class ReadersControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IServiceManager> _serviceMock;
    private readonly ReadersController _controller;

    public ReadersControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IServiceManager>>();
        _controller = new ReadersController(_serviceMock.Object); //creates the implementation in-memory
    }
    [Fact]
    public void ReaderControllerConstructor_ShouldReturnNullReferenceException_WhenServiceIsNull()
    {
        // Arrange
        IServiceManager feedbackService = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new ReadersController(feedbackService));
    }
    [Fact]
    public async Task GetReaders_ShouldReturnOkResponse_WhenDataFound()
    {
        // Arrange
        var feedbacksMock = _fixture.Create<IEnumerable<ReaderDto>>();
        _serviceMock.Setup(x => x.ReaderService.GetAllReadersAsync(false)).ReturnsAsync(feedbacksMock);

        // Act
        var result = await _controller.GetReaders().ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.ReaderService.GetAllReadersAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetReaders_ShouldReturnNotFound_WhenDataNotFound()
    {
        // Arrange
        List<ReaderDto> response = null;
        _serviceMock.Setup(x => x.ReaderService.GetAllReadersAsync(false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetReaders().ConfigureAwait(false);

        // Assert
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.ReaderService.GetAllReadersAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetReaderById_ShouldReturnOkResponse_WhenValidInput()
    {
        // Arrange
        var feedbackMock = _fixture.Create<ReaderDto>();
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.ReaderService.GetReaderAsync(id, false)).ReturnsAsync(feedbackMock);

        // Act
        var result = await _controller.GetReader(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.ReaderService.GetReaderAsync(id, false), Times.Once());
    }
    [Fact]
    public async Task GetReaderById_ShouldReturnNotFound_WhenNoDataFound()
    {
        // Arrange
        ReaderDto response = null;
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.ReaderService.GetReaderAsync(id, false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetReader(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.ReaderService.GetReaderAsync(id, false), Times.Once());
    }

    [Fact]
    public async Task CreateReader_ShouldReturnNoContent_WhenValidRequest()
    {
        // Arrange
        var request = _fixture.Create<ReaderDto>();
        var response = _fixture.Create<ReaderDto>();
        _serviceMock.Setup(x => x.ReaderService.CreateReaderAsync(request)).ReturnsAsync(response);

        // Act
        var result = await _controller.CreateReader(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.ReaderService.CreateReaderAsync(request), Times.Once());
    }
    [Fact]
    public async Task CreateReader_ShouldReturnBadRequest_WhenInvalidRequest()
    {
        // Arrange
        var request = _fixture.Create<ReaderDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<ReaderDto>();

        // Act
        var result = await _controller.CreateReader(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
    }
    [Fact]
    public async Task DeleteReader_ShouldReturnNoContents_WhenDeletedARecord()
    {
        // Arrange
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.ReaderService.DeleteReaderAsync(id, false));

        // Act
        var result = await _controller.DeleteReader(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.ReaderService.DeleteReaderAsync(id, false), Times.Once());

    }
    //[Fact]
    //public async Task DeleteReader_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    _serviceMock.Setup(x => x.ReaderService.DeleteReaderAsync(id, false));

    //    // Act
    //    var result = await _controller.DeleteReader(id).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //}

    [Fact]
    public async Task UpdateReader_ShouldReturnBadResponse_WhenInvalidRequest()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<ReaderDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<ReaderDto>();
        _serviceMock.Setup(x => x.ReaderService.UpdateReaderAsync(id, request, false));


        // Act
        var result = await _controller.UpdateReader(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
        _serviceMock.Verify(x => x.ReaderService.UpdateReaderAsync(id, request, false), Times.Never());
    }
    [Fact]
    public async Task UpdateReader_ShouldReturnNoContentResul_WhenRecordIsUpdated()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<ReaderDto>();
        _serviceMock.Setup(x => x.ReaderService.UpdateReaderAsync(id, request, true));

        // Act
        var result = await _controller.UpdateReader(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.ReaderService.UpdateReaderAsync(id, request, true), Times.Once());
    }
    //I don't know how to enter into the method from ReaderService.UpdateReaderAsync, we need to enter there because
    //we create exception there if object don't exsist with current id
    //
    //[Fact]
    //public async Task UpdateReader_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    var request = _fixture.Create<ReaderDto>();
    //    _serviceMock.Setup(x => x.ReaderService.UpdateReaderAsync(id, request, false))
    //        .Returns(Task.FromResult<ActionResult>(new NotFoundResult()));
    //    _serviceMock.CallBase = true;

    //    // Act
    //    var result = await _controller.UpdateReader(id, request).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //    _serviceMock.Verify(x => x.ReaderService.UpdateReaderAsync(id, request, false), Times.Once());
    //}

    //[Fact]
    //public async Task TestMethodName_WhatshouldHappens_WhenScenario()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //}
}

