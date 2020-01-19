using Renproj.Core;

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
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _rp.Execute();
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "RenameProjectWindow");
        }
    }
}