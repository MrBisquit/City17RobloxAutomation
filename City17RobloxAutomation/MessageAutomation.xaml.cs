using City17RobloxAutomation.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MessageAutomation.xaml
    /// </summary>
    public partial class MessageAutomation : Page
    {
        public MessageAutomation()
        {
            InitializeComponent();
        }

        public Regulation[] CombineRegulations = Defaults.CombineRegulations;
        public Regulation[] CivilianRegulations = Defaults.CivilianRegulations;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadRegulations();
            } catch { }
        }

        public void LoadRegulations()
        {
            if (Regulation == null) return;

            Regulation.Items.Clear();

            if (Category.SelectedIndex == 0)
            {
                foreach (var regulation in CombineRegulations)
                {
                    Regulation.Items.Add(new ComboBoxItem()
                    {
                        Name = "I" + regulation.Code.Replace(".", "_"),
                        Content = $"[{regulation.Code}] {regulation.Name}"
                    });
                }
            } else if(Category.SelectedIndex == 1)
            {
                foreach (var regulation in CivilianRegulations)
                {
                    Regulation.Items.Add(new ComboBoxItem()
                    {
                        Name = "I" + regulation.Code.Replace(".", "_"),
                        Content = $"[{regulation.Code}] {regulation.Name}"
                    });
                }
            }

            Regulation.SelectedIndex = 0;
            LoadVerdicts();
        }

        private void LoadVerdicts()
        {
            if(Regulation.SelectedIndex <= -1) return;
            string selectedRegulationCode = (Regulation.Items[Regulation.SelectedIndex] as ComboBoxItem).Name.Replace("_", ".").Replace("I", "");

            Verdict.Items.Clear();

            if(Category.SelectedIndex == 0)
            {
                Regulation selectedRegulation = null;

                foreach (var regulation in CombineRegulations)
                {
                    if(regulation.Code == selectedRegulationCode)
                    {
                        selectedRegulation = regulation;
                    }
                }

                if (selectedRegulation == null) return;

                foreach (var verdict in selectedRegulation.Verdicts)
                {
                    Verdict.Items.Add(new ComboBoxItem()
                    {
                        Name = $"V{verdict.Level}",
                        Content = verdict.Name
                    });
                }
            } else if(Category.SelectedIndex == 1)
            {
                Regulation selectedRegulation = null;

                foreach (var regulation in CivilianRegulations)
                {
                    if (regulation.Code == selectedRegulationCode)
                    {
                        selectedRegulation = regulation;
                    }
                }

                if (selectedRegulation == null) return;

                foreach (var verdict in selectedRegulation.Verdicts)
                {
                    Verdict.Items.Add(new ComboBoxItem()
                    {
                        Name = $"V{verdict.Level}",
                        Content = verdict.Name
                    });
                }
            }

            Verdict.SelectedIndex = 0;
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadRegulations();
        }

        private void Regulation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadVerdicts();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            SO.Visibility = Visibility.Collapsed;
            ST.Visibility = Visibility.Visible;

            GenerateMessages();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Category.SelectedIndex = 1;
            Regulation.SelectedIndex = 0;
            Verdict.SelectedIndex = 0;

            ST.Visibility = Visibility.Collapsed;
            SO.Visibility = Visibility.Visible;
        }

        private void GenerateMessages()
        {
            // Civilian, prepare to receive civil judgement

            List<string> messages = new List<string>();

            if (Regulation.SelectedIndex <= -1) return;
            string selectedRegulationCode = (Regulation.Items[Regulation.SelectedIndex] as ComboBoxItem).Name.Replace("_", ".").Replace("I", "");
            if(Verdict.SelectedIndex <= -1) return;
            string selectedVerdictCode = (Verdict.Items[Verdict.SelectedIndex] as ComboBoxItem).Name.Replace("_", ".").Replace("V", "");

            Verdict.Items.Clear();

            if (Category.SelectedIndex == 0)
            {
                Regulation selectedRegulation = null;
                Verdict selectedVerdict = null;

                foreach (var regulation in CombineRegulations)
                {
                    if (regulation.Code == selectedRegulationCode)
                    {
                        selectedRegulation = regulation;

                        foreach(var verdict in regulation.Verdicts)
                        {
                            if(verdict.Level.ToString() == selectedVerdictCode)
                            {
                                selectedVerdict = verdict;
                            }
                        }
                    }
                }

                // Some messages here
            }
            else if (Category.SelectedIndex == 1)
            {
                Regulation selectedRegulation = null;
                Verdict selectedVerdict = null;

                foreach (var regulation in CivilianRegulations)
                {
                    if (regulation.Code == selectedRegulationCode)
                    {
                        selectedRegulation = regulation;

                        foreach (var verdict in regulation.Verdicts)
                        {
                            if (verdict.Level.ToString() == selectedVerdictCode)
                            {
                                selectedVerdict = verdict;
                            }
                        }
                    }
                }

                messages.Add($"Suspect, you are being charged with {selectedRegulation.Code} ({selectedRegulation.Name.ToLowerInvariant()})");
                if (selectedVerdict != null)
                {
                    messages.Add($"You are receiving {selectedVerdict.Name.ToLowerInvariant()}");

                    if (selectedVerdict.Name == "CAPITAL PROSECUTION")
                    {
                        messages.Add("Suspect, prepare to receive civil judgement");
                    }
                }
            }

            ScrollViewer scrollViewer = new ScrollViewer();
            StackPanel stackPanel = new StackPanel();
            scrollViewer.Content = stackPanel;

            ST.Children.Add(scrollViewer);

            TextBlock textBlock = new TextBlock()
            {
                Text = "Click to copy, press Ctrl + V to paste",
                Margin = new Thickness(10)
            };

            stackPanel.Children.Add(textBlock);

            foreach (var message in messages)
            {
                TextBox textBox = new TextBox()
                {
                    Text = message,
                    Margin = new Thickness(10, 10, 10, 1),
                    TextWrapping = TextWrapping.Wrap,
                    Padding = new Thickness(5),
                    IsReadOnly = true
                };

                textBox.MouseLeftButtonDown += (object? sender, MouseButtonEventArgs args) =>
                {
                    //Clipboard.SetText(message);
                };

                textBlock.MouseUp += (object? sender, MouseButtonEventArgs args) =>
                {
                    //Clipboard.SetText(message);
                };

                Button copyButton = new Button()
                {
                    Content = "Copy message",
                    Padding = new Thickness(2),
                    Margin = new Thickness(10, 1, 10, 5)
                };

                copyButton.Click += (object sender, RoutedEventArgs args) =>
                {
                    Clipboard.SetText(message);
                };

                stackPanel.Children.Add(textBox);
                stackPanel.Children.Add(copyButton);
            }

            Button resetButton = new Button()
            {
                Content = "Reset",
                Margin = new Thickness(10),
                Padding = new Thickness(2),
            };

            resetButton.Click += Reset_Click;
            stackPanel.Children.Add(resetButton);
        }
    }
}
