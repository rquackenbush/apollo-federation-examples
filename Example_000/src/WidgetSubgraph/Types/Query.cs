using WidgetSubgraph.Data;

namespace WidgetSubgraph.Types
{
    public class Query
    {
        public IEnumerable<Widget> AllWidgets(WidgetRepository repository)
        {
            return repository.GetAllWidgets();
        }

        public Widget? GetWidget(WidgetRepository repository, string id) 
        {
            return repository.GetWidget(id);
        }
    }
}
