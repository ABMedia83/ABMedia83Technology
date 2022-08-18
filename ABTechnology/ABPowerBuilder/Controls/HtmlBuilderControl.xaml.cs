

namespace Controls;

/// <summary>
/// Interaction logic for HtmlBuilderControl.xaml
/// </summary>
public partial class HtmlBuilderControl : PowerView
{
    public ViewModelList<HtmlModel> pages;
    public HtmlBuilderControl()
    {
        InitializeComponent();
        Init();
    }

    public HtmlBuilderControl(TabControl _tab)
    {
        InitializeComponent();
        Init();
    }

    public HtmlBuilderControl(TabControl _tab, FileInfo _info )
    {
        InitializeComponent();
        Init();
    }




    public override void Init()
    {
        base.Init();
        lstPages.ItemsSource = Pages;
    }

    void List_Click(object sender, RoutedEventArgs e)
    {
        PushButton? push = (PushButton)sender!;

        switch(push!.Tag)
        {
            case "Add":
                btnRemove.IsEnabled = false;
                btnClear.IsEnabled = false;
                TabDialog.Show("Adding Page", "Do you want to Add a page?", "Add", "Cancel", () =>
                {
                    Pages.Add(new HtmlModel(txtTitle.Text, txtHead.Text, txtbBody.Text, txtFooter.Text));
                    //Turn other buttons back on 
                    btnRemove.IsEnabled = true;
                    btnClear.IsEnabled = true;

                },() =>
                {
                    btnRemove.IsEnabled = true;
                    btnClear.IsEnabled = true;
                });
                break;
            case "Remove":
                btnRemove.IsEnabled = false;
                btnClear.IsEnabled = false;
                TabDialog.Show("Removing Page", "Do you want to remove a Page?", "Remove", "Cancel", () =>
                {
                    if (lstPages.SelectedItem != null)
                    {
                        var item = lstPages.SelectedItem as HtmlModel;
                        Pages!.Remove(item!);
                    }
                    btnAdd.IsEnabled = true;
                    btnClear.IsEnabled = true;
                },()=>
                {
                    btnAdd.IsEnabled = true;
                    btnClear.IsEnabled = true;
                });
                break;
            case "Clear":
                btnAdd.IsEnabled = false;
                btnRemove.IsEnabled = false;
                TabDialog.Show("Clearing Pages", "Do you want to Clear ALL Pages?", "Remove", "Cancel", () =>
                {
                    Pages.Clear();
                    btnAdd.IsEnabled = true;
                    btnRemove.IsEnabled = true;
                }, () =>
                {
                    btnAdd.IsEnabled = true;
                    btnRemove.IsEnabled = true;
                });
                break;
        }

    }

    public ViewModelList<HtmlModel> Pages
    {
        get => pages;
        set => pages = value;
    }
}
