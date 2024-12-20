namespace DataStructuresApp;

public partial class List : ContentPage
{
    private LinkedList list;
	public List()
	{
		InitializeComponent();
        list = new LinkedList();
        UpdateVisual();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(InputEntry.Text, out int id))
        {
            list.AddLast(id);
            UpdateVisual();
            InputEntry.Text = string.Empty;
        }
        else
        {
            DisplayAlert("Error", "Please enter a valid number.", "OK");
        }

    }

    private void RemoveButton_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(RemoveEntry.Text, out int id))
        {
            if (list.RemoveValue(id))
            {
                UpdateVisual();
                RemoveEntry.Text = string.Empty;
            }
            else
            {
                RemoveEntry.Text = string.Empty;
                DisplayAlert("Error", "Value not found.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Please enter a valid number.", "OK");
        }

    }

    private void UpdateVisual()
    {
        LinkedListContainer.Children.Clear();

        //HeadLabel.Text = list.head.Data.ToString() ?? "null";
        //TailLabel.Text = list.tail.Data.ToString() ?? "null";

        if (list.head != null)
        {
            HeadLabel.Text = list.head.Data.ToString();
        }
        else
        {
            HeadLabel.Text = "null";
        }

        if (list.tail != null)
        {
            TailLabel.Text = list.tail.Data.ToString();
        }
        else
        {
            TailLabel.Text = "null";
        }

        var curr = list.head;
        while (curr != null)
        {
            var nodeView = new Frame
            {
                Content = new Label
                {
                    Text = curr.Data.ToString(),
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    TextColor = Colors.DarkBlue
                },
                BackgroundColor = Colors.LightBlue,
                BorderColor = Colors.DarkBlue,
                CornerRadius = 10,
                Padding = 10,
                Margin = new Thickness(5)
            };

            LinkedListContainer.Children.Add(nodeView);

            if (curr.Next != null)
            {
                LinkedListContainer.Children.Add(new Label
                {
                    Text = "→",
                    FontSize = 24,
                    VerticalOptions = LayoutOptions.Center,
                    TextColor = Colors.DarkBlue,
                });
            }

            curr = curr.Next;
        }

        if (list.head == null)
        {
            LinkedListContainer.Children.Add(new Label
            {
                Text = "null",
                FontSize = 24,
                VerticalOptions = LayoutOptions.Center,
                TextColor= Colors.DarkBlue,
            });
        }
        else
        {
            LinkedListContainer.Children.Add(new Label
            {
                Text = "→ null",
                FontSize = 24,
                VerticalOptions = LayoutOptions.Center,
                TextColor= Colors.DarkBlue,
            });
        }
    }
}