using System;

using R5T.T0132;


namespace R5T.Z0019.Construction
{
	[FunctionalityMarker]
	public partial interface ITry : IFunctionalityMarker
	{
		public void ExampleProjectFilePath()
        {
			var exampleProjectFilePath = Instances.ProjectFilePaths.Example;

			Console.WriteLine(exampleProjectFilePath);
        }
	}
}