using WebLibMVC.ViewModels;

namespace ServiceMVC.AuthorizeService;

    public interface IAuthorizeService
    {
        Task<string> AuthorizeAsync(AuthorizeViewModel authorizeViewModel);
    }

