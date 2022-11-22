using System;

using R5T.T0131;


namespace R5T.Z0019
{
	[ValuesMarker]
	public partial interface ISolutionFilePaths : IValuesMarker
	{
		public string Temp => @"C:\Temp\Temp.sln";
	}
}