using System.Collections.ObjectModel;
using System.Windows;

namespace SpikeItemsControlDraggable
{

    public class Task
    {
        public int Priority { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
    }
    public class MyData : ObservableCollection<Task>
    {
        public MyData()
        {
            Add(new Task { Priority = 1, TaskName = "toto", Description = "un truc" });
            Add(new Task { Priority = 2, TaskName = "titi", Description = "un truc" });
            Add(new Task { Priority = 3, TaskName = "tutu", Description = "un truc" });
        }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add1_OnClick(object sender, RoutedEventArgs e)
        {
            var dataList = (MyData) FindResource("DataList1");
            dataList.Add(new Task {Priority = 3, TaskName = "tutu", Description = "un truc"});
        }

        private void Add2_OnClick(object sender, RoutedEventArgs e)
        {
            var dataList = (MyData)FindResource("DataList2");
            dataList.Add(new Task { Priority = 3, TaskName = "trtr", Description = "un truc" });
        }
    }
}
