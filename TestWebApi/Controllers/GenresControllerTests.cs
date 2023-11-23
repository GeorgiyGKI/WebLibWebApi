using Entities.Exceptions;

namespace ApiTests.Controllers;

public class GenresControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IServiceManager> _serviceMock;
    private readonly GenresController _controller;

    public GenresControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IServiceManager>>();
        _controller = new GenresController(_serviceMock.Object); //creates the implementation in-memory
    }
    [Fact]
    public void GenreControllerConstructor_ShouldReturnNullReferenceException_WhenServiceIsNull()
    {
        // Arrange
        IServiceManager feedbackService = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new GenresController(feedbackService));
    }
    [Fact]
    public async Task GetGenres_ShouldReturnOkResponse_WhenDataFound()
    {
        // Arrange
        var feedbacksMock = _fixture.Create<IEnumerable<GenreDto>>();
        _serviceMock.Setup(x => x.GenreService.GetAllGenresAsync(false)).ReturnsAsync(feedbacksMock);

        // Act
        var result = await _controller.GetGenres().ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.GenreService.GetAllGenresAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetGenres_ShouldReturnNotFound_WhenDataNotFound()
    {
        // Arrange
        List<GenreDto> response = null;
        _serviceMock.Setup(x => x.GenreService.GetAllGenresAsync(false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetGenres().ConfigureAwait(false);

        // Assert
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.GenreService.GetAllGenresAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetGenreById_ShouldReturnOkResponse_WhenValidInput()
    {
        // Arrange
        var feedbackMock = _fixture.Create<GenreDto>();
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.GenreService.GetGenreAsync(id, false)).ReturnsAsync(feedbackMock);

        // Act
        var result = await _controller.GetGenre(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        _serviceMock.Verify(x => x.GenreService.GetGenreAsync(id, false), Times.Once());
    }
    [Fact]
    public async Task GetGenreById_ShouldReturnNotFound_WhenNoDataFound()
    {
        // Arrange
        GenreDto response = null;
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.GenreService.GetGenreAsync(id, false)).ReturnsAsync(response);

        // Act
        var result = await _controller.GetGenre(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NotFoundResult>();
        _serviceMock.Verify(x => x.GenreService.GetGenreAsync(id, false), Times.Once());
    }

    [Fact]
    public async Task CreateGenre_ShouldReturnNoContent_WhenValidRequest()
    {
        // Arrange
        var request = _fixture.Create<GenreDto>();
        var response = _fixture.Create<GenreDto>();
        _serviceMock.Setup(x => x.GenreService.CreateGenreAsync(request)).ReturnsAsync(response);

        // Act
        var result = await _controller.CreateGenre(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.GenreService.CreateGenreAsync(request), Times.Once());
    }
    [Fact]
    public async Task CreateGenre_ShouldReturnBadRequest_WhenInvalidRequest()
    {
        // Arrange
        var request = _fixture.Create<GenreDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");

        // Act
        var result = await _controller.CreateGenre(request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
    }
    [Fact]
    public async Task DeleteGenre_ShouldReturnNoContents_WhenDeletedARecord()
    {
        // Arrange
        var id = _fixture.Create<int>();
        _serviceMock.Setup(x => x.GenreService.DeleteGenreAsync(id, false));

        // Act
        var result = await _controller.DeleteGenre(id).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.GenreService.DeleteGenreAsync(id, false), Times.Once());


    }
    //!!!!
    [Fact]
    public async Task DeleteGenre_ShouldThrowGenreNotFoundException_WhenRecordNotFound()
    {
        // Arrange
        var id = 0;
        _serviceMock.Setup(x => x.GenreService.DeleteGenreAsync(id, false)).Throws(new GenreNotFoundException(id));

        // Assert
        await Assert.ThrowsAsync<GenreNotFoundException>(async () => await _controller.DeleteGenre(id));
    }

    [Fact]
    public async Task UpdateGenre_ShouldReturnBadResponse_WhenInvalidRequest()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<GenreDto>();
        _controller.ModelState.AddModelError("Subject", "The Subject field is required.");
        var response = _fixture.Create<GenreDto>();
        _serviceMock.Setup(x => x.GenreService.UpdateGenreAsync(id, request, false));


        // Act
        var result = await _controller.UpdateGenre(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<UnprocessableEntityObjectResult>();
        _serviceMock.Verify(x => x.GenreService.UpdateGenreAsync(id, request, false), Times.Never());
    }
    [Fact]
    public async Task UpdateGenre_ShouldReturnNoContentResul_WhenRecordIsUpdated()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var request = _fixture.Create<GenreDto>();
        _serviceMock.Setup(x => x.GenreService.UpdateGenreAsync(id, request, true));

        // Act
        var result = await _controller.UpdateGenre(id, request).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<NoContentResult>();
        _serviceMock.Verify(x => x.GenreService.UpdateGenreAsync(id, request, true), Times.Once());
    }
    //!!!!
    [Fact]
    public async Task UpdateGenre_ShouldThrowGenreNotFoundException_WhenRecordNotFound()
    {
        // Arrange
        var id = 0;
        GenreDto request = null;
        _serviceMock.Setup(x => x.GenreService.UpdateGenreAsync(id, request, false)).Throws(new GenreNotFoundException(id));
  

        // Act && Assert
        await Assert.ThrowsAsync<GenreNotFoundException>(async () => await _controller.UpdateGenre(id, request));
        _serviceMock.Verify(x => x.GenreService.UpdateGenreAsync(id, request, false), Times.Once());
    }

    //[Fact]
    //public async Task TestMethodName_WhatshouldHappens_WhenScenario()
    //{
    //    // Arrange

    //    // Act

    //    // Assert
    //}
}

