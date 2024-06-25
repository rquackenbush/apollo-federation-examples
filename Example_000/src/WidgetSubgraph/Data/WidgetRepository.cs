using WidgetSubgraph.Types;

namespace WidgetSubgraph.Data
{
    public class WidgetRepository
    {
        private readonly List<Widget> widgets = new List<Widget>
        {
            new Widget("1", "Widget 1"),
            new Widget("2", "Widget 2"),
            new Widget("3", "Widget 3"),
            new Widget("4", "Widget 4"),
        };

        public IEnumerable<Widget> GetAllWidgets()
        {
            return widgets;
        }

        public Widget? GetWidget(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new InvalidOperationException($"No id was specified.");

            return widgets
                .FirstOrDefault(w => w.Id == id);
        }

        public void DeleteWidget(string id)
        {
            var widget = GetWidget(id);

            if (widget == null)
                throw new InvalidOperationException($"Unable to find widget with id '{id}'.");

            widgets.Remove(widget);
        }

        public void AddWidget(string id, string name)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new InvalidOperationException($"No id was specified.");

            if (GetWidget(id) != null)  
                throw new InvalidOperationException($"A widget with id '{id}' already exists");

            var widget = new Widget(id, name);

            widgets.Add(widget);
        }

        public void RenameWidget(string id, string name)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new InvalidOperationException($"No id was specified.");

            var widget = GetWidget(id);

            if (widget == null)
                throw new InvalidOperationException($"Unable to find widget with id '{id}'.");

            widget.Name = name;
        }
    }
}
