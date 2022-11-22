using System;


namespace R5T.Z0019
{
	public class SolutionFilePaths : ISolutionFilePaths
	{
		#region Infrastructure

	    public static ISolutionFilePaths Instance { get; } = new SolutionFilePaths();

	    private SolutionFilePaths()
	    {
        }

	    #endregion
	}
}