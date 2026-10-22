using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class166 : DelegatingHandler
{
	private readonly string string_0;

	internal Class166(HttpMessageHandler httpMessageHandler_0, string string_1)
		: base(httpMessageHandler_0)
	{
		string_0 = string_1;
	}

	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		request.Headers.Authorization = ((!(request.RequestUri.Scheme == Uri.UriSchemeHttps) || !(request.RequestUri.Host == Class185.smethod_0(-1141296605)) || string.IsNullOrWhiteSpace(string_0)) ? ((AuthenticationHeaderValue)null) : new AuthenticationHeaderValue(Class185.smethod_0(-1141296618), string_0));
		return ((DelegatingHandler)this).SendAsync(request, cancellationToken);
	}
}
