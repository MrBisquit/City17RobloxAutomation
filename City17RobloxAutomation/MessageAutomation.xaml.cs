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
    }
}
