# How to show or hide the drag indicator like iOS listview?
This example demonstrates how to show or hide the drag indicator like native iOS applications.

## Sample

```xaml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="40"/>
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <Button x:Name="editButton" Grid.Row="0" Text="Click to show drag indicator" Command="{Binding TapCommand}"/>
    <syncfusion:SfListView x:Name="listView" AutoFitMode="Height"
                        ItemSize="70" Grid.Row="1"
                        ItemsSource="{Binding ContactsInfo}"
                        DragStartMode="OnHold,OnDragIndicator"
                        SelectionMode="None">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <ViewCell.View>
                        <Grid x:Name="grid" RowSpacing="0">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="*" />
                                <RowDefinition Height="1" />
                            </Grid.RowDefinitions>
                            . . .
                            . . .

                                <syncfusion:DragIndicatorView IsVisible="{Binding IndicatorVisible}" ListView="{x:Reference listView}" HorizontalOptions="Center" VerticalOptions="Center">
                                    <Grid Padding="10, 10, 10, 10">
                                        <Image Source="DragIndicator.png" VerticalOptions="Center" HorizontalOptions="Center" />
                                    </Grid>
                                </syncfusion:DragIndicatorView>

                            <code>
                            . . .
                            . . .
                            <code>
                        </Grid>
                    </ViewCell.View>
                </ViewCell>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
</Grid>

ViewModel.cs:
Command<object> tapCommand;

public Command<object> TapCommand
{
    get { return tapCommand; }
    protected set { tapCommand = value; }
}

TapCommand = new Command<object>(OnTapped);

private void OnTapped(object obj)
{
    for (int i = 0; i < ContactsInfo.Count; i++)
    {
        ContactsInfo[i].IndicatorVisible = true;
    }
}
```

See [How to show or hide the drag indicator like iOS listview?](https://www.syncfusion.com/kb/9981/how-to-show-or-hide-the-drag-indicator-like-ios-listview) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.