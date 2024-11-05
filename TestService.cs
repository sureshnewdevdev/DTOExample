namespace DTOExample
{
    public class TestService : ITestService
    {
        public string GetBuildVersionNumber()
        {
            return (new Random()).Next(0, 180).ToString();
        }
    }
}
