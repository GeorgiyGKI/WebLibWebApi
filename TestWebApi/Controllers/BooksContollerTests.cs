namespace ApiTests.Controllers;

public class BooksControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IServiceManager> _serviceMock;
    private readonly BooksController _controller;

    public BooksControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IServiceManager>>();
        _controller = new BooksController(_serviceMock.Object); //creates the implementation in-memory
    }
    [Fact]
    public void BookControllerConstructor_ShouldReturnNullReferenceException_WhenServiceIsNull()
    {
        // Arrange
        IServiceManager feedbackService = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new BooksController(feedbackService));
    }
    [Fact]
    public async Task GetBooks_ShouldReturnOkResponse_WhenDataFound()
    {
        // Arrange
        var feedbacksMock = _fixture.Create<IEnumerable<BookDto>>();
        _serviceMock.Setup(x => x.BookService.GetAllBooksAsync(false)).ReturnsAsync(feedbacksMock);

        // Act
        var result = await _controller.GetBooks().ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.BookService.GetAllBooksAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetBooks_ShouldReturnNotFound_WhenDataNotFound()
    {
        // Arrange
        List<BookDto> response = null;
        _serviceMock.Setup(x => x.BookService.GetAllBooksAsync(false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetBooks().ConfigureAwait(false);

        // Assert
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.BookService.GetAllBooksAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetBookById_ShouldReturnOkResponse_WhenValidInput()
    {
        // Arrange
        var feedbackMock = _fixture.Create<BookDto>();
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.BookService.GetBookAsync(id, false)).ReturnsAsync(feedbackMock);

        // Act
        var result = await _controller.GetBook(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.BookService.GetBookAsync(id, false), Times.Once());
    }
    [Fact]
    public async Task GetBookById_ShouldReturnNotFound_WhenNoDataFound()
    {
        // Arrange
        BookDto response = null;
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.BookService.GetBookAsync(id, false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetBook(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.BookService.GetBookAsync(id, false), Times.Once());
    }

    [Fact]
    public async Task CreateBook_ShouldReturnNoContent_WhenValidRequest()
    {
        // Arrange
        var request = _fixture.Create<BookDto>();
        var response = _fixture.Create<BookDto>();
        _serviceMock.Setup(x => x.BookService.CreateBookAsync(request)).ReturnsAsync(response);

        // Act
        var result = await _controller.CreateBook(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.BookService.CreateBookAsync(request), Times.Once());
    }
    [Fact]
    public async Task CreateBook_ShouldReturnBadRequest_WhenInvalidRequest()
    {
        // Arrange
        var request = _fixture.Create<BookDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<BookDto>();

        // Act
        var result = await _controller.CreateBook(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
    }
    [Fact]
    public async Task DeleteBook_ShouldReturnNoContents_WhenDeletedARecord()
    {
        // Arrange
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.BookService.DeleteBookAsync(id, false));

        // Act
        var result = await _controller.DeleteBook(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.BookService.DeleteBookAsync(id, false), Times.Once());

    }
    //[Fact]
    //public async Task DeleteBook_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    _serviceMock.Setup(x => x.BookService.DeleteBookAsync(id, false));

    //    // Act
    //    var result = await _controller.DeleteBook(id).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //}

    [Fact]
    public async Task UpdateBook_ShouldReturnBadResponse_WhenInvalidRequest()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<BookDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<BookDto>();
        _serviceMock.Setup(x => x.BookService.UpdateBookAsync(id, request, false));


        // Act
        var result = await _controller.UpdateBook(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
        _serviceMock.Verify(x => x.BookService.UpdateBookAsync(id, request, false), Times.Never());
    }
    [Fact]
    public async Task UpdateBook_ShouldReturnNoContentResul_WhenRecordIsUpdated()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<BookDto>();
        _serviceMock.Setup(x => x.BookService.UpdateBookAsync(id, request, true));

        // Act
        var result = await _controller.UpdateBook(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.BookService.UpdateBookAsync(id, request, true), Times.Once());
    }
    //I don't know how to enter into the method from BookService.UpdateBookAsync, we need to enter there because
    //we create exception there if object don't exsist with current id
    //
    //[Fact]
    //public async Task UpdateBook_ShouldReturnNotFound_WhenRecordNotFound()
    //{
    //    // Arrange
    //    var id = _fixture.Create<int>();
    //    var request = _fixture.Create<BookDto>();
    //    _serviceMock.Setup(x => x.BookService.UpdateBookAsync(id, request, false))
    //        .Returns(Task.FromResult<ActionResult>(new NotFoundResult()));
    //    _serviceMock.CallBase = true;

    //    // Act
    //    var result = await _controller.UpdateBook(id, request).ConfigureAwait(false);

    //    // Assert
    //    result.Should().NotBeNull();
    //    result.Should().BeAssignableTo<NotFoundResult>();
    //    _serviceMock.Verify(x => x.BookService.UpdateBookAsync(id, request, false), Times.Once());
    //}

    //[Fact]
    //public async Task TestMethodName_WhatshouldHappens_WhenScenario()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //}
}

