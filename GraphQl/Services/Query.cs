namespace GraphQl.Services
{
    [ExtendObjectType("method")]
    public class Query
    {
        public int GetNumber(int a)
        {
            return a * a;
        }
    }
}
