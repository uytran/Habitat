﻿namespace xHelix.Foundation.Baseline.Services
{
    using Sitecore.Data;

    public interface ITrackerService
    {
        bool IsActive { get; }
        void IdentifyContact(string identifier);
        void TrackOutcome(ID definitionId);
        void TrackPageEvent(ID pageEventItemId, string text = null, string data = null, string dataKey = null, int? value = null);
    }
}