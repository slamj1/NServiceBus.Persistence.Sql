﻿#pragma warning disable 1591
namespace NServiceBus.Persistence.Sql
{
    using System;

    /// <summary>
    /// Not for public use.
    /// </summary>
    [Obsolete("Not for public use")]
    public class OutboxCommands
    {
        public string Store;
        public string Get;
        public string SetAsDispatched;
        public string Cleanup;

        public OutboxCommands(string store, string get, string setAsDispatched, string cleanup)
        {
            Store = store;
            Get = get;
            SetAsDispatched = setAsDispatched;
            Cleanup = cleanup;
        }
    }
}