#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="HttpRequest" />
[Tool, GlobalClass]
public abstract partial class HttpRequestComponent : NodeComponent
{

    /// <inheritdoc cref="HttpRequest.Request(string, string[], HttpClient.Method, string)" />
    public Error Request(string @url, string[] @customHeaders, HttpClient.Method @method, string @requestData) => ((HttpRequest)_host).Request(@url, @customHeaders, @method, @requestData);

    /// <inheritdoc cref="HttpRequest.Request(string, ReadOnlySpan{string}, HttpClient.Method, string)" />
    public Error Request(string @url, ReadOnlySpan<string> @customHeaders, HttpClient.Method @method, string @requestData) => ((HttpRequest)_host).Request(@url, @customHeaders, @method, @requestData);

    /// <inheritdoc cref="HttpRequest.RequestRaw(string, string[], HttpClient.Method, byte[])" />
    public Error RequestRaw(string @url, string[] @customHeaders, HttpClient.Method @method, byte[] @requestDataRaw) => ((HttpRequest)_host).RequestRaw(@url, @customHeaders, @method, @requestDataRaw);

    /// <inheritdoc cref="HttpRequest.RequestRaw(string, ReadOnlySpan{string}, HttpClient.Method, ReadOnlySpan{byte})" />
    public Error RequestRaw(string @url, ReadOnlySpan<string> @customHeaders, HttpClient.Method @method, ReadOnlySpan<byte> @requestDataRaw) => ((HttpRequest)_host).RequestRaw(@url, @customHeaders, @method, @requestDataRaw);

    /// <inheritdoc cref="HttpRequest.CancelRequest()" />
    public void CancelRequest() => ((HttpRequest)_host).CancelRequest();

    /// <inheritdoc cref="HttpRequest.SetTlsOptions(TlsOptions)" />
    public void SetTlsOptions(TlsOptions @clientOptions) => ((HttpRequest)_host).SetTlsOptions(@clientOptions);

    /// <inheritdoc cref="HttpRequest.GetHttpClientStatus()" />
    public HttpClient.Status GetHttpClientStatus() => ((HttpRequest)_host).GetHttpClientStatus();

    /// <inheritdoc cref="HttpRequest.SetUseThreads(bool)" />
    public void SetUseThreads(bool @enable) => ((HttpRequest)_host).SetUseThreads(@enable);

    /// <inheritdoc cref="HttpRequest.IsUsingThreads()" />
    public bool IsUsingThreads() => ((HttpRequest)_host).IsUsingThreads();

    /// <inheritdoc cref="HttpRequest.SetAcceptGZip(bool)" />
    public void SetAcceptGZip(bool @enable) => ((HttpRequest)_host).SetAcceptGZip(@enable);

    /// <inheritdoc cref="HttpRequest.IsAcceptingGZip()" />
    public bool IsAcceptingGZip() => ((HttpRequest)_host).IsAcceptingGZip();

    /// <inheritdoc cref="HttpRequest.SetBodySizeLimit(int)" />
    public void SetBodySizeLimit(int @bytes) => ((HttpRequest)_host).SetBodySizeLimit(@bytes);

    /// <inheritdoc cref="HttpRequest.GetBodySizeLimit()" />
    public int GetBodySizeLimit() => ((HttpRequest)_host).GetBodySizeLimit();

    /// <inheritdoc cref="HttpRequest.SetMaxRedirects(int)" />
    public void SetMaxRedirects(int @amount) => ((HttpRequest)_host).SetMaxRedirects(@amount);

    /// <inheritdoc cref="HttpRequest.GetMaxRedirects()" />
    public int GetMaxRedirects() => ((HttpRequest)_host).GetMaxRedirects();

    /// <inheritdoc cref="HttpRequest.SetDownloadFile(string)" />
    public void SetDownloadFile(string @path) => ((HttpRequest)_host).SetDownloadFile(@path);

    /// <inheritdoc cref="HttpRequest.GetDownloadFile()" />
    public string GetDownloadFile() => ((HttpRequest)_host).GetDownloadFile();

    /// <inheritdoc cref="HttpRequest.GetDownloadedBytes()" />
    public int GetDownloadedBytes() => ((HttpRequest)_host).GetDownloadedBytes();

    /// <inheritdoc cref="HttpRequest.GetBodySize()" />
    public int GetBodySize() => ((HttpRequest)_host).GetBodySize();

    /// <inheritdoc cref="HttpRequest.SetTimeout(double)" />
    public void SetTimeout(double @timeout) => ((HttpRequest)_host).SetTimeout(@timeout);

    /// <inheritdoc cref="HttpRequest.GetTimeout()" />
    public double GetTimeout() => ((HttpRequest)_host).GetTimeout();

    /// <inheritdoc cref="HttpRequest.SetDownloadChunkSize(int)" />
    public void SetDownloadChunkSize(int @chunkSize) => ((HttpRequest)_host).SetDownloadChunkSize(@chunkSize);

    /// <inheritdoc cref="HttpRequest.GetDownloadChunkSize()" />
    public int GetDownloadChunkSize() => ((HttpRequest)_host).GetDownloadChunkSize();

    /// <inheritdoc cref="HttpRequest.SetHttpProxy(string, int)" />
    public void SetHttpProxy(string @host, int @port) => ((HttpRequest)_host).SetHttpProxy(@host, @port);

    /// <inheritdoc cref="HttpRequest.SetHttpsProxy(string, int)" />
    public void SetHttpsProxy(string @host, int @port) => ((HttpRequest)_host).SetHttpsProxy(@host, @port);

}
