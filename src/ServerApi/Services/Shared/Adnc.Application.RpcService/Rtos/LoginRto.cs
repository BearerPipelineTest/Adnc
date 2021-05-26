﻿using System.ComponentModel.DataAnnotations;

namespace Adnc.Application.RpcService.Rtos
{
    public class LoginRto
    {
        /// <summary>
        /// 账户
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}