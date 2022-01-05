using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0112.SourceCode
{
    [ServiceDefinitionMarker]
    public interface IVersionControlSystemDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetVersionControlSystemDirectoryPath();
    }
}