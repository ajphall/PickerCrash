using System.Collections.ObjectModel;

namespace PickerCrash;

public class TestModel
{
    public string Name { get; set; }
}

public partial class MainPage : ContentPage
{
    public ObservableCollection<TestModel> Test { get; } = new ObservableCollection<TestModel>();

    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
        Test.Add(new TestModel());
    }	
}

