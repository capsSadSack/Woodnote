using BirdClassification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WoodnoteMobileUI.Views.BirdSearch;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodnoteMobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BirdSearchPage : ContentPage
    {
        public BirdSearchPage()
        {
            InitializeComponent();

            InitializeBirdSilhouetteLayout();
        }


        private void InitializeBirdSilhouetteLayout()
        {
            IEnumerable<Order> allBirdsOrders = EnumProcessor.GetAllValues(Order.Casuariiformes);

            const int columNum = 2;
            int rowNum = (int)Math.Ceiling((double)allBirdsOrders.Count() / columNum);

            for (int row = 0; row < rowNum; row++)
            {
                RowDefinition rowDefinition = new RowDefinition()
                {
                    Height = new GridLength(1, GridUnitType.Star)
                };
                birdSilhouetteGrid.RowDefinitions.Insert(2, rowDefinition);
               
                for (int col = 0; col < columNum; col++)
                {
                    int currentNumber = row * columNum + col;

                    if (currentNumber < allBirdsOrders.Count())
                    {
                        string orderNameEn = Enum.GetName(typeof(Order), currentNumber);
                        string orderName = Properties.biologyClass.ResourceManager.GetString("Order_" + orderNameEn);

                        SilhouetteView view = new SilhouetteView("WoodnoteMobileUI.Resources.Anseriformes_Silhouette_150х200.png", orderName);
                        AddChild(birdSilhouetteGrid, view, 2 + row, 1 + col, 1, 1);
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