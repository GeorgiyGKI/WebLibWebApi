namespace ApiTests.Controllers;

public class TransactionStatusesControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IServiceManager> _serviceMock;
    private readonly TransactionStatusesController _controller;

    public TransactionStatusesControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IServiceManager>>();
        _controller = new TransactionStatusesController(_serviceMock.Object); //creates the implementation in-memory
    }
    [Fact]
    public void TransactionStatusControllerConstructor_ShouldReturnNullReferenceException_WhenServiceIsNull()
    {
        // Arrange
        IServiceManager feedbackService = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new TransactionStatusesController(feedbackService));
    }
    [Fact]
    public async Task GetTransactionStatuses_ShouldReturnOkResponse_WhenDataFound()
    {
        // Arrange
        var feedbacksMock = _fixture.Create<IEnumerable<TransactionStatusDto>>();
        _serviceMock.Setup(x => x.TransactionStatusService.GetAllTransactionStatusesAsync(false)).ReturnsAsync(feedbacksMock);

        // Act
        var result = await _controller.GetTransactionStatuses().ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.TransactionStatusService.GetAllTransactionStatusesAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetTransactionStatuses_ShouldReturnNotFound_WhenDataNotFound()
    {
        // Arrange
        List<TransactionStatusDto> response = null;
        _serviceMock.Setup(x => x.TransactionStatusService.GetAllTransactionStatusesAsync(false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetTransactionStatuses().ConfigureAwait(false);

        // Assert
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.GetAllTransactionStatusesAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetTransactionStatusById_ShouldReturnOkResponse_WhenValidInput()
    {
        // Arrange
        var feedbackMock = _fixture.Create<TransactionStatusDto>();
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.TransactionStatusService.GetTransactionStatusAsync(id, false)).ReturnsAsync(feedbackMock);

        // Act
        var result = await _controller.GetTransactionStatus(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.TransactionStatusService.GetTransactionStatusAsync(id, false), Times.Once());
    }
    [Fact]
    public async Task GetTransactionStatusById_ShouldReturnNotFound_WhenNoDataFound()
    {
        // Arrange
        TransactionStatusDto response = null;
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.TransactionStatusService.GetTransactionStatusAsync(id, false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetTransactionStatus(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.GetTransactionStatusAsync(id, false), Times.Once());
    }

    [Fact]
    public async Task CreateTransactionStatus_ShouldReturnNoContent_WhenValidRequest()
    {
        // Arrange
        var request = _fixture.Create<TransactionStatusDto>();
        var response = _fixture.Create<TransactionStatusDto>();
        _serviceMock.Setup(x => x.TransactionStatusService.CreateTransactionStatusAsync(request)).ReturnsAsync(response);

        // Act
        var result = await _controller.CreateTransactionStatus(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.CreateTransactionStatusAsync(request), Times.Once());
    }
    [Fact]
    public async Task CreateTransactionStatus_ShouldReturnBadRequest_WhenInvalidRequest()
    {
        // Arrange
        var request = _fixture.Create<TransactionStatusDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<TransactionStatusDto>();

        // Act
        var result = await _controller.CreateTransactionStatus(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
    }
    [Fact]
    public async Task DeleteTransactionStatus_ShouldReturnNoContents_WhenDeletedARecord()
    {
        // Arrange
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.TransactionStatusService.DeleteTransactionStatusAsync(id, false));

        // Act
        var result = await _controller.DeleteTransactionStatus(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.DeleteTransactionStatusAsync(id, false), Times.Once());

    }
    //[Fact]
    //public async Task DeleteTransactionStatus_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    _serviceMock.Setup(x => x.TransactionStatusService.DeleteTransactionStatusAsync(id, false));

    //    // Act
    //    var result = await _controller.DeleteTransactionStatus(id).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //}

    [Fact]
    public async Task UpdateTransactionStatus_ShouldReturnBadResponse_WhenInvalidRequest()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<TransactionStatusDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<TransactionStatusDto>();
        _serviceMock.Setup(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, false));


        // Act
        var result = await _controller.UpdateTransactionStatus(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, false), Times.Never());
    }
    [Fact]
    public async Task UpdateTransactionStatus_ShouldReturnNoContentResul_WhenRecordIsUpdated()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<TransactionStatusDto>();
        _serviceMock.Setup(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, true));

        // Act
        var result = await _controller.UpdateTransactionStatus(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, true), Times.Once());
    }
    //I don't know how to enter into the method from TransactionStatusService.UpdateTransactionStatusAsync, we need to enter there because
    //we create exception there if object don't exsist with current id
    //
    //[Fact]
    //public async Task UpdateTransactionStatus_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    var request = _fixture.Create<TransactionStatusDto>();
    //    _serviceMock.Setup(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, false))
    //        .Returns(Task.FromResult<ActionResult>(new NotFoundResult()));
    //    _serviceMock.CallBase = true;

    //    // Act
    //    var result = await _controller.UpdateTransactionStatus(id, request).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //    _serviceMock.Verify(x => x.TransactionStatusService.UpdateTransactionStatusAsync(id, request, false), Times.Once());
    //}

    //[Fact]
    //public async Task TestMethodName_WhatshouldHappens_WhenScenario()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //}
}

