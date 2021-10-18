using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WoodnoteWPF.Views
{
    /// <summary>
    /// Interaction logic for MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {
        private Point _scrollMousePoint = new Point();
        private double _horizontalOffset = 1;
        private double _verticalOffset = 1;


        public MapView()
        {
            InitializeComponent();
        }

        private void ScrollViewer_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            _scrollMousePoint = e.GetPosition(scrollViewer);
            _horizontalOffset = scrollViewer.HorizontalOffset;
            _verticalOffset = scrollViewer.VerticalOffset;

            scrollViewer.CaptureMouse();
            Mouse.OverrideCursor = Cursors.SizeAll;
        }

        private void ScrollViewer_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (scrollViewer.IsMouseCaptured)
            {
                scrollViewer.ScrollToHorizontalOffset(_horizontalOffset + (_scrollMousePoint.X - e.GetPosition(scrollViewer).X));
                scrollViewer.ScrollToVerticalOffset(_verticalOffset + (_scrollMousePoint.Y - e.GetPosition(scrollViewer).Y));
            }
        }

        private void ScrollViewer_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
            scrollViewer.ReleaseMouseCapture();
        }
    }
}
