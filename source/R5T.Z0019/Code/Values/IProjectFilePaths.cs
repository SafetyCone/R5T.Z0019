using System;

using R5T.T0131;


namespace R5T.Z0019
{
	[ValuesMarker]
	public partial interface IProjectFilePaths : IValuesMarker
	{
		public string Example => Instances.ProjectPathsOperator.GetProjectFilePath(
			Instances.DirectoryPaths.Temp,
			Instances.ProjectNames.Example);
	}
}