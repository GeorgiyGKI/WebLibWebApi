
//namespace ApiTests.Controllers;

//public class TransactionsControllerTests
//{
//    private readonly IFixture _fixture;
//    private readonly Mock<IServiceManager> _serviceMock;
//    private readonly TransactionsController _controller;

//    public TransactionsControllerTests()
//    {
//        _fixture = new Fixture();
//        _serviceMock = _fixture.Freeze<Mock<IServiceManager>>();
//        _controller = new TransactionsController(_serviceMock.Object); //creates the implementation in-memory
//    }
//    [Fact]
//    public void TransactionControllerConstructor_ShouldReturnNullReferenceException_WhenServiceIsNull()
//    {
//        // Arrange
//        IServiceManager feedbackService = null;

//        // Act && Assert
//        Assert.Throws<ArgumentNullException>(() => new TransactionsController(feedbackService));
//    }
//    [Fact]
//    public async Task GetTransactions_ShouldReturnOkResponse_WhenDataFound()
//    {
//        // Arrange
//        var feedbacksMock = _fixture.Create<IEnumerable<TransactionDto>>();
//        _serviceMock.Setup(x => x.TransactionService.GetAllTransactionsAsync(false)).ReturnsAsync(feedbacksMock);

//        // Act
//        var result = await _controller.GetTransactions().ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        _serviceMock.Verify(x => x.TransactionService.GetAllTransactionsAsync(false), Times.Once());
//    }
//    [Fact]
//    public async Task GetTransactions_ShouldReturnNotFound_WhenDataNotFound()
//    {
//        // Arrange
//        List<TransactionDto> response = null;
//        _serviceMock.Setup(x => x.TransactionService.GetAllTransactionsAsync(false)).ReturnsAsync(response);

//        // Act
//        var result = await _controller.GetTransactions().ConfigureAwait(false);

//        // Assert
//        result.Should().BeAssignableTo<NotFoundResult>();
//        _serviceMock.Verify(x => x.TransactionService.GetAllTransactionsAsync(false), Times.Once());
//    }
//    [Fact]
//    public async Task GetTransactionById_ShouldReturnOkResponse_WhenValidInput()
//    {
//        // Arrange
//        var feedbackMock = _fixture.Create<TransactionDto>();
//        var id = _fixture.Create<int>();
//        _serviceMock.Setup(x => x.TransactionService.GetTransactionAsync(id, false)).ReturnsAsync(feedbackMock);

//        // Act
//        var result = await _controller.GetTransaction(id).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        _serviceMock.Verify(x => x.TransactionService.GetTransactionAsync(id, false), Times.Once());
//    }
//    [Fact]
//    public async Task GetTransactionById_ShouldReturnNotFound_WhenNoDataFound()
//    {
//        // Arrange
//        TransactionDto response = null;
//        var id = _fixture.Create<int>();
//        _serviceMock.Setup(x => x.TransactionService.GetTransactionAsync(id, false)).ReturnsAsync(response);

//        // Act
//        var result = await _controller.GetTransaction(id).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<NotFoundResult>();
//        _serviceMock.Verify(x => x.TransactionService.GetTransactionAsync(id, false), Times.Once());
//    }

//    [Fact]
//    public async Task CreateTransaction_ShouldReturnNoContent_WhenValidRequest()
//    {
//        // Arrange
//        var request = _fixture.Create<TransactionDto>();
//        var response = _fixture.Create<TransactionDto>();
//        _serviceMock.Setup(x => x.TransactionService.CreateTransactionAsync(request)).ReturnsAsync(response);

//        // Act
//        var result = await _controller.CreateTransaction(request).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<NoContentResult>();
//        _serviceMock.Verify(x => x.TransactionService.CreateTransactionAsync(request), Times.Once());
//    }
//    [Fact]
//    public async Task CreateTransaction_ShouldReturnBadRequest_WhenInvalidRequest()
//    {
//        // Arrange
//        var request = _fixture.Create<TransactionDto>();
//        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
//        var response = _fixture.Create<TransactionDto>();

//        // Act
//        var result = await _controller.CreateTransaction(request).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
//    }
//    [Fact]
//    public async Task DeleteTransaction_ShouldReturnNoContents_WhenDeletedARecord()
//    {
//        // Arrange
//        var id = _fixture.Create<int>();
//        _serviceMock.Setup(x => x.TransactionService.DeleteTransactionAsync(id, false));

//        // Act
//        var result = await _controller.DeleteTransaction(id).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<NoContentResult>();
//        _serviceMock.Verify(x => x.TransactionService.DeleteTransactionAsync(id, false), Times.Once());

//    }
//    //[Fact]
//    //public async Task DeleteTransaction_ShouldReturnNotFound_WhenRecordNotFound()
//    //{
//    //    // Arrange
//    //    var id = _fixture.Create<int>();
//    //    _serviceMock.Setup(x => x.TransactionService.DeleteTransactionAsync(id, false));

//    //    // Act
//    //    var result = await _controller.DeleteTransaction(id).ConfigureAwait(false);

//    //    // Assert
//    //    result.Should().NotBeNull();
//    //    result.Should().BeAssignableTo<NotFoundResult>();
//    //}

//    [Fact]
//    public async Task UpdateTransaction_ShouldReturnBadResponse_WhenInvalidRequest()
//    {
//        // Arrange
//        var id = _fixture.Create<int>();
//        var request = _fixture.Create<TransactionDto>();
//        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
//        var response = _fixture.Create<TransactionDto>();
//        _serviceMock.Setup(x => x.TransactionService.UpdateTransactionAsync(id, request, false));


//        // Act
//        var result = await _controller.UpdateTransaction(id, request).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
//        _serviceMock.Verify(x => x.TransactionService.UpdateTransactionAsync(id, request, false), Times.Never());
//    }
//    [Fact]
//    public async Task UpdateTransaction_ShouldReturnNoContentResul_WhenRecordIsUpdated()
//    {
//        // Arrange
//        var id = _fixture.Create<int>();
//        var request = _fixture.Create<TransactionDto>();
//        _serviceMock.Setup(x => x.TransactionService.UpdateTransactionAsync(id, request, true));

//        // Act
//        var result = await _controller.UpdateTransaction(id, request).ConfigureAwait(false);

//        // Assert
//        result.Should().NotBeNull();
//        result.Should().BeAssignableTo<NoContentResult>();
//        _serviceMock.Verify(x => x.TransactionService.UpdateTransactionAsync(id, request, true), Times.Once());
//    }
//    //I don't know how to enter into the method from TransactionService.UpdateTransactionAsync, we need to enter there because
//    //we create exception there if object don't exsist with current id
//    //
//    //[Fact]
//    //public async Task UpdateTransaction_ShouldReturnNotFound_WhenRecordNotFound()
//    //{
//    //    // Arrange
//    //    var id = _fixture.Create<int>();
//    //    var request = _fixture.Create<TransactionDto>();
//    //    _serviceMock.Setup(x => x.TransactionService.UpdateTransactionAsync(id, request, false))
//    //        .Returns(Task.FromResult<ActionResult>(new NotFoundResult()));
//    //    _serviceMock.CallBase = true;

//    //    // Act
//    //    var result = await _controller.UpdateTransaction(id, request).ConfigureAwait(false);

//    //    // Assert
//    //    result.Should().NotBeNull();
//    //    result.Should().BeAssignableTo<NotFoundResult>();
//    //    _serviceMock.Verify(x => x.TransactionService.UpdateTransactionAsync(id, request, false), Times.Once());
//    //}

//    //[Fact]
//    //public async Task TestMethodName_WhatshouldHappens_WhenScenario()
//    //{
//    //    // Arrange

//    //    // Act

//    //    // Assert
//    //}
//}

