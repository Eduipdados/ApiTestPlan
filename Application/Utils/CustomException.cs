using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Api.Application.Utils
{
    [ExcludeFromCodeCoverage]
    public class CustomException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public CustomException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }

        public static CustomException BadRequest(string message) =>
            new (HttpStatusCode.BadRequest, message);

        public static CustomException EntityNotFound(string message) =>
            new (HttpStatusCode.NotFound, message);

        public static CustomException ErroValidacao(string message) =>
           new (HttpStatusCode.BadRequest, message);
    }
}
