﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspacer
{
    public interface IWindowRouter
    {
        IWorkspace RouteWindow(IWindow window, IWorkspace defaultWorkspace = null);
    }
}