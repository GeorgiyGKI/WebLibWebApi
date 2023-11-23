using NuGet.Frameworks;

namespace CoreTests.Services;
public class GenreServiceTests
{

    private readonly IFixture _fixture;
    private readonly Mock<IRepositoryManager> _repositoryMock;
    private readonly Mock<ILoggerManager> _loggerMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly GenreService _sut;

    public GenreServiceTests()
    {
        _fixture = new Fixture();
        _repositoryMock = _fixture.Freeze<Mock<IRepositoryManager>>();
        _loggerMock = _fixture.Freeze<Mock<ILoggerManager>>();
        var mapperMock = new Mock<IMapper>().Object;
        _fixture.Inject(mapperMock);
        _mapperMock = new Mock<IMapper>();
        _sut = new GenreService(_repositoryMock.Object, _loggerMock.Object, _mapperMock.Object);
    }

    [Fact]
    public void GenreServiceConstructor_ShouldReturnNullReferenceException_WhenRepositoryIsNull()
    {
        // Arrange
        IRepositoryManager repository = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new GenreService(repository, _loggerMock.Object, _mapperMock.Object));
    }

    [Fact]
    public void GenreServiceConstructor_ShouldReturnNullReferenceException_WhenLoggerIsNull()
    {
        // Arrange            
        ILoggerManager logger = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new GenreService(_repositoryMock.Object, logger, _mapperMock.Object));
    }
    [Fact]
    public void GenreServiceConstructor_ShouldReturnNullReferenceException_WhenMapperIsNull()
    {
        // Arrange            
        IMapper mapper = null;

        // Act && Assert
        Assert.Throws<ArgumentNullException>(() => new GenreService(_repositoryMock.Object, _loggerMock.Object, mapper));
    }


    [Fact]
    public async Task GetAllGenre_ShouldReturnData_WhenDataFound()
    {
        // Arrange
        var genres = _fixture.Create<IEnumerable<Genre>>();
        _repositoryMock.Setup(x => x.Genre.GetAllGenresAsync(false)).ReturnsAsync(genres);

        // Act
        var result = await _sut.GetAllGenresAsync(false).ConfigureAwait(false);

        // Assert
        //Assert.NotNull(result);
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<IEnumerable<GenreDto>>();
        _repositoryMock.Verify(x => x.Genre.GetAllGenresAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetAllGenre_ShouldReturnNull_WhenDataNotFound()
    {
        // Arrange
        IEnumerable<Genre> genres = null;
        _repositoryMock.Setup(x => x.Genre.GetAllGenresAsync(false)).ReturnsAsync(genres);

        // Act
        var result = await _sut.GetAllGenresAsync(false).ConfigureAwait(false);

        // Assert
        result.Should().BeNull();
        _repositoryMock.Verify(x => x.Genre.GetAllGenresAsync(false), Times.Once());
    }
    [Fact]
    public async Task GetGenreById_ShouldReturnData_WhenDataFound()
    {
        // Arrange
        var id = _fixture.Create<int>();
        var genre = _fixture.Create<Genre>();
        var genreDto = _fixture.Create<GenreDto>();
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).ReturnsAsync(genre);
        _mapperMock.Setup(x => x.Map<GenreDto>(genre)).Returns(genreDto);

        // Act
        var result = await _sut.GetGenreAsync(id, false).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<GenreDto>();
        _repositoryMock.Verify(x => x.Genre.GetGenreAsync(id, false), Times.Once());
        _mapperMock.Verify(x => x.Map<GenreDto>(genre), Times.Once);
    }
    [Fact]
    public async Task GetGenreById_ShouldReturnNull_WhenDataNotFound()
    {
        // Arrange
        var id = 0;
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).Throws(new GenreNotFoundException(id));


        // Act && Assert
        await Assert.ThrowsAsync<GenreNotFoundException>(async () => await _sut.GetGenreAsync(id, false));
        _repositoryMock.Verify(x => x.Genre.GetGenreAsync(id, false), Times.Once());
    }
 
    [Fact]
    public async Task CreateGenre_ShouldReturnData_WhenDataIsInsertedSucessfully()
    {
        // Arrange
        var genre = _fixture.Create<Genre>();
        var genreDto = _fixture.Create<GenreDto>();
        _mapperMock.Setup(x => x.Map<Genre>(genreDto)).Returns(genre);
        _mapperMock.Setup(x => x.Map<GenreDto>(genre)).Returns(genreDto);
        _repositoryMock.Setup(x => x.Genre.CreateGenre(genre));

        // Act
        var result = await _sut.CreateGenreAsync(genreDto).ConfigureAwait(false);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<GenreDto>();
        _mapperMock.Verify(x => x.Map<Genre>(genreDto), Times.Once);
        _mapperMock.Verify(x => x.Map<GenreDto>(genre), Times.Once);
        _repositoryMock.Verify(x => x.Genre.CreateGenre(genre), Times.Once());
    }
    [Fact]
    public void CreateGenre_ShouldThrowNullReferenceException_WhenInputIsNull()
    {
        // Arrange
        var genre = _fixture.Create<Genre>();
        GenreDto request = null;
        _repositoryMock.Setup(x => x.Genre.CreateGenre(genre));

        // Act
        var result = () => _sut.CreateGenreAsync(request);

        // Assert
        result.Should().ThrowAsync<ArgumentNullException>();
    }
    [Fact]
    public async Task DeleteGenre_ShouldReturnTrue_WhenDataIsDeletedSuccessfully()
    {
        // Arrange
        var genre = _fixture.Create<Genre>();
        var id = _fixture.Create<int>();
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).ReturnsAsync(genre);
        _repositoryMock.Setup(x => x.Genre.DeleteGenre(genre));

        // Act
        await _sut.DeleteGenreAsync(id, false).ConfigureAwait(false);

        // Assert
        _repositoryMock.Verify(x => x.Genre.DeleteGenre(genre), Times.Once());
    }
    [Fact]
    public async Task DeleteGenre_ShouldReturnFalse_WhenDataNotFound()
    {
        // Arrange
        var id = 0;
        Genre genre = null;
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).Throws(new GenreNotFoundException(id));

        // Act && Assert
        await Assert.ThrowsAsync<GenreNotFoundException>(async () => await _sut.DeleteGenreAsync(id, false));
        _repositoryMock.Verify(x => x.Genre.DeleteGenre(genre), Times.Never());
    }

    [Fact]
    public async Task UpdateGenre_ShouldReturnTrue_WhenDataUpdatedSucessfully()
    {
        // Arrange
        var genreResult = _fixture.Create<Genre>();
        var genreForUpdate = _fixture.Create<GenreDto>();
        var id = genreForUpdate.Id;
        _mapperMock.Setup(x => x.Map(genreForUpdate, genreResult));
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, true)).ReturnsAsync(genreResult); 

        // Act
        await _sut.UpdateGenreAsync(id, genreForUpdate, true).ConfigureAwait(false);

        // Assert
        _mapperMock.Verify(x => x.Map(genreForUpdate, genreResult), Times.Once);
    }
    [Fact]
    public async Task UpdateGenre_ShouldReturnFalse_WhenDataNotFound()
    {
        // Arrange
        var genreForUpdate = _fixture.Create<GenreDto>();
        var id = genreForUpdate.Id;
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).Throws(new GenreNotFoundException(id));

        // Act && Assert
        await Assert.ThrowsAsync<GenreNotFoundException>(async () => await _sut.UpdateGenreAsync(id, genreForUpdate, false));
        _repositoryMock.Verify(x => x.Genre.GetGenreAsync(id, false), Times.Once());
    }

    [Fact]
    public async Task UpdateGenre_ShouldThrowNullReferenceException_WhenRequestIsNull()
    {
        // Arrange
        var id = _fixture.Create<int>();
        GenreDto genreForUpdate = null;
        var genre = _fixture.Create<Genre>();
        _repositoryMock.Setup(x => x.Genre.GetGenreAsync(id, false)).ReturnsAsync(genre);
        _mapperMock.Setup(x => x.Map(genre, genreForUpdate)).Throws(new NullReferenceException());

        // Act
        await Assert.ThrowsAsync<NullReferenceException>(async () => await _sut.UpdateGenreAsync(id, genreForUpdate,  false));
        _repositoryMock.Verify(x => x.Genre.GetGenreAsync(id, false), Times.Once());

    }
}

