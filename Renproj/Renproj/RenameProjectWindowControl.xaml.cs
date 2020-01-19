using System.Collections.ObjectModel;
using System.Windows.Input;
using Renproj.Core;
using Renproj.Core.Projects;

namespace Renproj
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for RenameProjectWindowControl.
    /// </summary>
    public partial class RenameProjectWindowControl : UserControl
    {
        private readonly Rp _rp;

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameProjectWindowControl"/> class.
        /// </summary>
        public RenameProjectWindowControl()
        {
            this.InitializeComponent();

            _rp = new Rp(new ProjectService());

            var allProjects = _rp.GetProjects();
            Projects = new ObservableCollection<SolutionProject>(allProjects);
            LvProjectsList.ItemsSource = Projects;
        }

        private void LbProjectsList_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!(LvProjectsList.SelectedItem is SolutionProject slnProj))
                return;

            MessageBox.Show(slnProj.Name);
        }

        public ObservableCollection<SolutionProject> Projects { get; set; }
    }
}