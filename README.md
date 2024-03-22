# Xamarin Rotator (SfRotator)

The Rotator is a data control used to display image data and navigate through them. The images can be selected either by Thumbnail or by Dots support.

For know more details about Rotator: https://www.syncfusion.com/xamarin-ui-controls/xamarin-rotator

Rotator user guide documentation: https://help.syncfusion.com/xamarin/rotator/getting-started

##   Create a Simple SfRotator
The SfRotator control is configured entirely in C# code or by using XAML markup. The following steps explain on how to create a SfRotator and configure its elements,

Adding namespace for the added assemblies.

**[XAML]**
```
xmlns:rotator="clr-namespace:Syncfusion.SfRotator.XForms;assembly=Syncfusion.SfRotator.XForms"
```
**[XAML]**
Now add the SfRotator control with a required optimal name by using the included namespace.

```
<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" 
	xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
	xmlns:local="clr-namespace:GettingStarted" 
	xmlns:syncfusion="clr-namespace:Syncfusion.SfRotator.XForms;assembly=Syncfusion.SfRotator.XForms"
	x:Class="GettingStarted.RotatorControlPage">
<ContentPage.Content>
 <syncfusion:SfRotator x:Name="rotator" />	
</ContentPage.Content>
</ContentPage>
```

## Add Rotator Items
We can populate the rotator’s items by using any one of the following ways,

*   Through SfRotatorItem

*   Through ItemTemplate

###  Through SfRotatorItem
By passing the list of SfRotatorItem , we can get the view of SfRotator control. In that we can pass Images as well as Item content.

The following code example illustrates to add list of Images in Rotator ,

**[C#]**

```
public partial class Rotator : ContentPage
	{
        SfRotator rotator = new SfRotator();
        StackLayout stackLayout = new StackLayout();
		public Rotator()
		{
			InitializeComponent ();
            stackLayout.HeightRequest = 300;
            List<SfRotatorItem> collectionOfItems = new List<SfRotatorItem>();
            collectionOfItems.Add(new SfRotatorItem() { Image = "movie1.png" });
            collectionOfItems.Add(new SfRotatorItem() { Image = "movie2.png" });
            collectionOfItems.Add(new SfRotatorItem() { Image = "movie3.png" });
            collectionOfItems.Add(new SfRotatorItem() { Image = "movie4.png" });
            collectionOfItems.Add(new SfRotatorItem() { Image = "movie5.png" });
            rotator.DataSource = collectionOfItems;
            stackLayout.Children.Add(rotator);
            this.Content = stackLayout;
        }
	}
```

The following code example illustrates to add list of items through ItemContent API in Rotator ,

**[C#]**

```
 public partial class Rotator : ContentPage
    {
        SfRotator rotator;
        public Rotator()
        {
            InitializeComponent();
            SfRotator rotator = new SfRotator();
            List<SfRotatorItem> collectionOfItems = new List<SfRotatorItem>();
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Xamarin.Forms.Button() { Text = "RotatorButton", TextColor = Color.White, BackgroundColor = Color.FromHex("#7E6E6B"), FontSize = 12 } });
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Label() { Text = "RotatorLabel", BackgroundColor = Color.FromHex("#7E6E6B"), FontSize = 12 } });
            collectionOfItems.Add(new SfRotatorItem() { ItemContent = new Image() { Source = "image1.png", Aspect = Aspect.AspectFit } });
            rotator.DataSource = collectionOfItems;
            this.Content = rotator;
        }
    }
```
###  Through ItemTemplate
ItemTemplate property of SfRotator control is used to customize the contents of SfRotator items. ItemTemplate provides common template with different data. SfRotator items can be populated with a collection of image data. This collection includes Arrays, Lists and DataTables.

**[C#]**
```
public RotatorModel(string imageString)
{
    Image = imageString;
}
private String _image;
public String Image
{
    get { return _image; }
    set { _image = value; }
}
```
Create and populate Rotator collection as follows

```
public RotatorViewModel()
{
    ImageCollection.Add(new RotatorModel("movie1.png"));
    ImageCollection.Add(new RotatorModel("movie2.png"));
    ImageCollection.Add(new RotatorModel("movie3.png"));
    ImageCollection.Add(new RotatorModel("movie4.png"));
    ImageCollection.Add(new RotatorModel("movie5.png"));
}
private List<RotatorModel> imageCollection = new List<RotatorModel>();
public List<RotatorModel> ImageCollection
{
    get { return imageCollection; }
    set { imageCollection = value; }
}
```
**[XAML]**

```
    <ContentPage.BindingContext>
        <local:RotatorViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Content>
        <syncfusion:SfRotator x:Name="rotator" 
                        NavigationDelay="2000" 
                        ItemsSource="{Binding ImageCollection}" 
                        SelectedIndex="2"
                        NavigationDirection="Horizontal"
                        NavigationStripMode="Dots" 
                        BackgroundColor="#ececec">
            <syncfusion:SfRotator.ItemTemplate>
                <DataTemplate>
                    <Image  Source="{Binding Image}"/>
                </DataTemplate>
            </syncfusion:SfRotator.ItemTemplate>
        </syncfusion:SfRotator>
    </ContentPage.Content>
```
*   Set the BindingContext for the items collection.

**[XAML]**
```
<ContentPage.BindingContext>
        <local:RotatorViewModel/>
</ContentPage.BindingContext>
```