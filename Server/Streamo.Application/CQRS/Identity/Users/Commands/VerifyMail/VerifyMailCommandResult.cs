using Streamo.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streamo.Application.CQRS.Identity.Users.Commands.VerifyMail
{
    public class VerifyMailCommandResult
    {
        public Result Result { get; set; } = null!;
        public string? Token { get; set; } = null!;
    }
}
