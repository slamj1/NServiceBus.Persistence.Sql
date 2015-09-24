﻿using NServiceBus;
using NServiceBus.Features;


class TimeoutFeature : Feature
{

    TimeoutFeature()
    {
        DependsOn<TimeoutManager>();
        base.RegisterStartupTask<StartupTask>();
    }

    class StartupTask:FeatureStartupTask
    {
        protected override void OnStart()
        {
            
        }
    }

    protected override void Setup(FeatureConfigurationContext context)
    {
        var connectionString = context.Settings.GetConnectionString();
        var schema = context.Settings.GetSchema();
        var endpointName = context.Settings.EndpointName();
        var persister = new TimeoutPersister(connectionString, schema, endpointName);
        context.Container.ConfigureComponent(() => persister, DependencyLifecycle.InstancePerCall);
    }
}