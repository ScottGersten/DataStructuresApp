namespace DataStructuresApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void StackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack());
        }

        private async void QueueButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Queue());
        }

        private async void ListButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new List());
        }

        private void BSTButton_Clicked(object sender, EventArgs e)
        {

        }

        private void AVLButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SplayButton_Clicked(object sender, EventArgs e)
        {

        }

        private void BinaryHeapButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SkewHeapButton_Clicked(object sender, EventArgs e)
        {

        }

        private void LeftistHeapButton_Clicked(object sender, EventArgs e)
        {

        }
    }

}
