﻿using System.Collections.Generic;

namespace NServiceBus.SqlPersistence
{
    public class SagaDefinition
    {
        public string Name { get; set; }
        public Dictionary<string, string> MessageMappings { get; set; }
        public List<string> UniqueProperties { get; set; }
    }
}