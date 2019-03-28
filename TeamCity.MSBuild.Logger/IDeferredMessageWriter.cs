﻿namespace TeamCity.MSBuild.Logger
{
    using Microsoft.Build.Framework;

    internal interface IDeferredMessageWriter
    {
        void DisplayDeferredProjectStartedEvent(BuildEventContext e);

        void DisplayDeferredStartedEvents(BuildEventContext e);

        void DisplayDeferredTargetStartedEvent(BuildEventContext e);

        void ShownBuildEventContext(BuildEventContext e);
    }
}