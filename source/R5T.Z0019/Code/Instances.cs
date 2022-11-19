using System;

using R5T.F0052;
using R5T.Z0015;


namespace R5T.Z0019
{
    public static class Instances
    {
        public static IDirectoryPaths DirectoryPaths { get; } = Z0015.DirectoryPaths.Instance;
        public static IProjectNames ProjectNames { get; } = Z0019.ProjectNames.Instance;
        public static IProjectPathsOperator ProjectPathsOperator { get; } = F0052.ProjectPathsOperator.Instance;
    }
}