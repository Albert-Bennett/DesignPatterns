namespace Builder.AssemblyLine
{
    public class AssemblyLineClient
    {
        readonly IAssemblyLine _assemblyLine;

        public AssemblyLineClient(
            IAssemblyLine assemblyLine)
        {
            _assemblyLine = assemblyLine;
        }

        public void BuildCar()
        {
            _assemblyLine.SetName().MakeMake().PaintCar();
        }
    }
}
