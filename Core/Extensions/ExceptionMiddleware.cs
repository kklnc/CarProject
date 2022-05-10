using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            httpContext.Response.ContentType = "application/json";//content type biz json gönderiyoruz diyoruz
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;//burada hata olursa internalservererror hata vermişiz statu kdodunu mesajı da aşağıda 

            IEnumerable<ValidationFailure> errors;//hataları kendi listemizi oluşturup onun içine koyacağız
            string message = "Internal Server Error";
            if (e.GetType() == typeof(ValidationException))//eğer aldığım hata val.iex. ise mesajı  yukardaki mesajla değiştir demişiz
            {
                message = e.Message;
                errors = ((ValidationException)e).Errors;//validation satasu olduğu için statuskodunu değiştiriyoruz
                httpContext.Response.StatusCode = 400;

                return httpContext.Response.WriteAsync(new ValidationErrorDetails
                {
                    StatusCode = 400,
                    Message = message,
                    ValidationErrors = errors
                }.ToString());
            }

            return httpContext.Response.WriteAsync(new ErrorDetails //vereceğin responsu da bu şekilde ver demişiz.
                                                                    //eğer databaseden hata alıyorsak burası çalışacak
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = message
            }.ToString());
        }
    }
}
