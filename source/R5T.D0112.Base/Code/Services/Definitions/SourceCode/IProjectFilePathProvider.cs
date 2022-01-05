using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0112.SourceCode
{
    [ServiceDefinitionMarker]
    public interface IProjectFilePathProvider : IServiceDefinition
    {
        Task<string> GetProjectFilePath(
            string repositoryName,
            string projectDirectoryName,
            string projectFileName);
    }
}