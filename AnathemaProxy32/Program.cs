﻿using AnathemaProxy;
using System;

namespace AnathemaProxy32
{
    /// <summary>
    /// Program to handle operations that are required to be run in 32 bit mode.
    /// This is needed when Ana is running in 64 bit and editing a 32 bit application
    /// </summary>
    class Program
    {
        private static ProxyService ProxyService;

        static void Main(String[] Args)
        {
            ProxyService = new ProxyService();
        }

    } // End class

} // End namespace