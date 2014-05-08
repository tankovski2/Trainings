using BuildMyOwnFramework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyOwnFramework.Infrastructure
{
    public interface ICurrentUser
    {
       ApplicationUser User { get; } 
    }
}