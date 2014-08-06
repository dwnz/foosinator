using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Foosinator.Startup))]

namespace Foosinator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
