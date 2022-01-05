using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0112.SourceCode
{
    [ServiceDefinitionMarker]
    public interface IRepositoryDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetRepositoryDirectoryName(string repositoryName);
    }
}