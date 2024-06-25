using WidgetSubgraph.Data;

namespace WidgetSubgraph.Types
{
    public class Mutation
    {
        public Payload DeleteWidget(WidgetRepository repository, string id)
        {
            try
            {
                repository.DeleteWidget(id);

                return new Payload(true, "Widget added.");
            }
            catch(Exception ex)
            {
                return new Payload(false, ex.Message);
            }
        }

        public Payload AddWidget(WidgetRepository repository, AddWidgetInput input)
        {
            try
            { 
                repository.AddWidget(input.Id, input.Name);

                return new Payload(true, "Widget deleted.");
            }
            catch(Exception ex)
            {
                return new Payload(false, ex.Message);
            }
        }

        public Payload RenameWidget(WidgetRepository repository, RenameWidgetInput input)
        {
            try
            {
                repository.RenameWidget(input.Id, input.Name);

                return new Payload(true, "Widget renamed.");
            }
            catch (Exception ex)
            {
                return new Payload(false, ex.Message);
            }
        }
    }
}
