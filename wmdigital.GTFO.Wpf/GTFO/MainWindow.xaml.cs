using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GTFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush ActiveColor = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            GetOutlinePaths(e.Key).Fill = ActiveColor;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
           GetOutlinePaths(e.Key).Fill = null;
        }

        private Path GetOutlinePaths(Key key)
        {
            string outline = key.ToString() + "LetterOutline";
            return (from r in ControlOutlines.Children.OfType<Path>()
                                              where r.Name == key.ToString() + "Letter"
                                              select r).FirstOrDefault<Path>();
        }
    }
}