namespace WebLibMVC.Handler
{
    public class AuthorizationHeaderHandler : DelegatingHandler
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthorizationHeaderHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = _httpContextAccessor.HttpContext.Request.Cookies[".AspNetCore.Application.Id"];

            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Add("Authorization", "Bearer " + token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
