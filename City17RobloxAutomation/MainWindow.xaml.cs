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
        public Regulation[] CivilianRegulations = Defaults.CivilianRegulations;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCombineRegulations();
            LoadCivilianRegulations();

            MessageAutomation messageAutomation = new MessageAutomation();
            AutomationFrame.Content = messageAutomation.Content;
            messageAutomation.LoadRegulations();
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

                    levelsVerdicts.Add(regulation.Level, regulation.Verdicts.ToArray());
                }

                StackPanel item = new StackPanel()
                {
                    Margin = new Thickness(0, 10, 0, 10)
                };
                TextBlock title = new TextBlock()
                {
                    Text = $"[{regulation.Code}] {regulation.Name}",
                    TextWrapping = TextWrapping.Wrap,
                    FontSize = 15,
                    FontWeight = FontWeights.SemiBold
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

            foreach (var item in levelsVerdicts)
            {
                StackPanel verdicts = new StackPanel();

                TextBlock title = new TextBlock()
                {
                    Text = "Verdicts",
                    FontSize = 20
                };

                verdicts.Children.Add(title);

                if (levelsVerdicts.ContainsKey(item.Key))
                {
                    Verdict[] verdictList = levelsVerdicts[item.Key];

                    foreach (var verdict in verdictList)
                    {
                        TextBlock verdictText = new TextBlock()
                        {
                            Text = $"{verdict.Level}. {verdict.Name}"
                        };

                        verdicts.Children.Add(verdictText);
                    }

                    levels[item.Key].Children.Add(verdicts);
                }
            }
        }

        private void LoadCivilianRegulations()
        {
            Dictionary<int, StackPanel> levels = new Dictionary<int, StackPanel>();
            Dictionary<int, Verdict[]> levelsVerdicts = new Dictionary<int, Verdict[]>();
            WrapPanel wrapPanel = new WrapPanel();

            CivilianRegulationsTI.Children.Add(wrapPanel);

            foreach (var regulation in CivilianRegulations)
            {
                if (!levels.ContainsKey(regulation.Level))
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

                    levelsVerdicts.Add(regulation.Level, regulation.Verdicts.ToArray());
                }

                StackPanel item = new StackPanel()
                {
                    Margin = new Thickness(0, 10, 0, 10)
                };
                TextBlock title = new TextBlock()
                {
                    Text = $"[{regulation.Code}] {regulation.Name}",
                    TextWrapping = TextWrapping.Wrap,
                    FontSize = 15,
                    FontWeight = FontWeights.SemiBold
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

            foreach (var item in levelsVerdicts)
            {
                StackPanel verdicts = new StackPanel();

                TextBlock title = new TextBlock()
                {
                    Text = "Verdicts",
                    FontSize = 20
                };

                verdicts.Children.Add(title);

                if (levelsVerdicts.ContainsKey(item.Key))
                {
                    Verdict[] verdictList = levelsVerdicts[item.Key];

                    foreach (var verdict in verdictList)
                    {
                        TextBlock verdictText = new TextBlock()
                        {
                            Text = $"{verdict.Level}. {verdict.Name}"
                        };

                        verdicts.Children.Add(verdictText);
                    }

                    levels[item.Key].Children.Add(verdicts);
                }
            }
        }
    }
}