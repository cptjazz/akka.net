﻿//-----------------------------------------------------------------------
// <copyright file="EmptyReadOnlyCollections.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2019 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2019 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Akka.Util.Internal.Collections
{
    public class EmptyReadOnlyCollections<T>
    {
        private static readonly ReadOnlyCollection<T> _instance = new ReadOnlyCollection<T>(new T[0]);

        public static IReadOnlyCollection<T> Collection { get { return _instance; } }
        public static IReadOnlyList<T> List { get { return _instance; } }
    }
}

