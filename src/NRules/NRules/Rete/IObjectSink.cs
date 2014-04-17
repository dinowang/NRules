﻿namespace NRules.Rete
{
    internal interface IObjectSink
    {
        void PropagateAssert(IExecutionContext context, Fact fact);
        void PropagateUpdate(IExecutionContext context, Fact fact);
        void PropagateRetract(IExecutionContext context, Fact fact);
    }
}