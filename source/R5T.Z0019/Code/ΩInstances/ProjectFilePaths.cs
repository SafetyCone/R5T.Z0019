using System;


namespace R5T.Z0019
{
	public class ProjectFilePaths : IProjectFilePaths
	{
		#region Infrastructure

	    public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();

	    private ProjectFilePaths()
	    {
        }

	    #endregion
	}
}