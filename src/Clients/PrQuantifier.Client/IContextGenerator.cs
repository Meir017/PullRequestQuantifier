﻿namespace PrQuantifier.Client
***REMOVED***
    using System.Threading.Tasks;
    using global::PrQuantifier.Core.Context;

    public interface IContextGenerator
    ***REMOVED***
        /// <summary>
        /// Generate a context by given a repo path.
        /// </summary>
        /// <param name="repoPath">The repo  path.</param>
        /// <returns>returns a context.</returns>
        Task<Context> Create(string repoPath);
***REMOVED***
***REMOVED***
