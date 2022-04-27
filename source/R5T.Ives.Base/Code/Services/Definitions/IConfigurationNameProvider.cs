using System;

using R5T.T0064;


namespace R5T.Ives
{
    [ServiceDefinitionMarker]
    public interface IConfigurationNameProvider : IServiceDefinition
    {
        string GetConfigurationName();
    }
}
