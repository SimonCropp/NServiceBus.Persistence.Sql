﻿using System;

namespace NServiceBus.Persistence.SqlServerXml
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    public class TransitionalCorrelationIdAttribute : Attribute
    {
    }
}