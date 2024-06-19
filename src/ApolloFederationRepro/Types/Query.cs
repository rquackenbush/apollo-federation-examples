namespace ApolloFederationRepro.Types
{
    public class Query
    {
        public List<Widget> AllWidgets()
        {
            return new List<Widget>
            {
                new Widget("1", "Widget 1"),
                new Widget("2", "Widget 2"),
                new Widget("3", "Widget 3")
            };
        }
    }
}
