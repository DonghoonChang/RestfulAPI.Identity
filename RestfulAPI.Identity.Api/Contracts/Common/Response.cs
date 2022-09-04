﻿namespace RestfulAPI.Identity.Contracts.Common;

public class Response
{
    public string? Status { get; set; }
    public string? Message { get; set; }
    public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();
}