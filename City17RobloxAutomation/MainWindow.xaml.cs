using City17RobloxAutomation.Types;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace City17RobloxAutomation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Regulation[] CombineRegulations = Defaults.CombineRegulations;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCombineRegulations();
        }

        private void LoadCombineRegulations()
        {
            Dictionary<int, StackPanel> levels = new Dictionary<int, StackPanel>();
            Dictionary<int, Verdict[]> levelsVerdicts = new Dictionary<int, Verdict[]>();
            WrapPanel wrapPanel = new WrapPanel();

            CombineRegulationsTI.Children.Add(wrapPanel);

            foreach (var regulation in CombineRegulations)
            {
                if(!levels.ContainsKey(regulation.Level))
                {
                    StackPanel items = new StackPanel();
                    items.Margin = new Thickness(5);
                    items.Width = 350;
                    TextBlock iTitle = new TextBlock()
                    {
                        Text = $"Level {regulation.Level} Regulations",
                        FontSize = 20
                    };
                    items.Children.Add(iTitle);
                    levels[regulation.Level] = items;
                    wrapPanel.Children.Add(levels[regulation.Level]);

                    levelsVerdicts.Add(regulation.Level, regulation.Verdicts);
                }

                StackPanel item = new StackPanel()
                {
                    Margin = new Thickness(0, 10, 0, 10)
                };
                TextBlock title = new TextBlock()
                {
                    Text = $"[{regulation.Code}] {regulation.Name}",
                    FontSize = 15
                };

                TextBlock description = new TextBlock()
                {
                    Text = regulation.Description,
                    TextWrapping = TextWrapping.Wrap,
                    Width = 300,
                };

                item.Children.Add(title);
                item.Children.Add(description);

                levels[regulation.Level].Children.Add(item);
            }

            foreach (var item in levels)
            {
                StackPanel verdicts = new StackPanel();

                TextBlock title = new TextBlock()
                {
                    Text = "Verdicts",
                    FontSize = 20
                };

                Verdict[] verdictList = levelsVerdicts[item.Key];

                foreach (var verdict in verdictList)
                {
                    
                }
            }
        }
    }
}