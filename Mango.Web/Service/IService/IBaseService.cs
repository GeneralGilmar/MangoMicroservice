﻿using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IBaseService
    {
      //  Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
