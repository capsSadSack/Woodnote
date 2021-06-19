using BirdClassification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodnoteMobileUI.Views.BirdSearch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SilhouetteSelectionView : ContentView
    {
        public SilhouetteSelectionView()
        {
            InitializeComponent();

            InitializeBirdSilhouetteLayout();
        }

        private void InitializeBirdSilhouetteLayout()
        {
            IEnumerable<Order> allBirdsOrders = EnumProcessor.GetAllValues(Order.Casuariiformes);
            
            IEnumerable<Order> mainBirdsOrder = new List<Order>
            { 
                Order.Accipitriformes, 
                Order.Aepyornithiformes,
                Order.Anseriformes, 
                Order.Apodiformes,
                Order.Apterygiformes,
                Order.Bucerotiformes
            };

            IEnumerable<Order> extraBirdsOrders = allBirdsOrders.Where(x => !mainBirdsOrder.Contains(x));

            FillGrid(mainBirdsOrder, mainBirdSilhouetteGrid);
            FillGrid(extraBirdsOrders, extraBirdSilhouetteGrid);
        }

        private void FillGrid(IEnumerable<Order> birdsOrders, Grid grid)
        {
            const int columNum = 3;
            int rowNum = (int)Math.Ceiling((double)birdsOrders.Count() / columNum);

            for (int row = 0; row < rowNum; row++)
            {
                RowDefinition rowDefinition = new RowDefinition()
                {
                    Height = new GridLength(1, GridUnitType.Auto)
                };
                grid.RowDefinitions.Insert(1, rowDefinition);

                for (int col = 0; col < columNum; col++)
                {
                    int currentNumber = row * columNum + col;

                    if (currentNumber < birdsOrders.Count())
                    {
                        string orderNameEn = Enum.GetName(typeof(Order), birdsOrders.ElementAt(currentNumber));
                        string orderName = Properties.biologyClass.ResourceManager.GetString("Order_" + orderNameEn);
                        string imageFileName = @"WoodnoteMobileUI.Resources." + orderNameEn + @"_Silhouette_150х200.png";

                        SilhouetteView view = new SilhouetteView(imageFileName, orderName);
                        AddChild(grid, view, 1 + row, 0 + col, 1, 1);
                    }
                }
            }
        }

        private void AddChild(Grid grid, View view, int row, int column, int rowspan = 1, int columnspan = 1)
        {
            if (row < 0)
                throw new ArgumentOutOfRangeException("row");
            if (column < 0)
                throw new ArgumentOutOfRangeException("column");
            if (rowspan <= 0)
                throw new ArgumentOutOfRangeException("rowspan");
            if (columnspan <= 0)
                throw new ArgumentOutOfRangeException("columnspan");
            if (view == null)
                throw new ArgumentNullException("view");

            Grid.SetRow((BindableObject)view, row);
            Grid.SetRowSpan((BindableObject)view, rowspan);
            Grid.SetColumn((BindableObject)view, column);
            Grid.SetColumnSpan((BindableObject)view, columnspan);

            grid.Children.Add(view);
        }
    }
}