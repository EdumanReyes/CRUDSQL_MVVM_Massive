using Crud.ViewModel;
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

namespace Crud.View
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Esta función fue creada para poder configurar el tamaño de las columnas del DataGrid
            ConfigColumnasDataGrid();
            

        }

        private void ConfigColumnasDataGrid()
        {
            //Configuración de columnas y estilos datagrid
            DataGridTextColumn idColumn = new DataGridTextColumn
            {
                Header = "ID",
                Binding = new Binding("Id"),
                Width = new DataGridLength(1, DataGridLengthUnitType.SizeToHeader) 
            };
            DataGridTextColumn edadColumn = new DataGridTextColumn
            {
                Header = "Edad",
                Binding = new Binding("Edad"),
                Width = new DataGridLength(1, DataGridLengthUnitType.SizeToHeader) 
            };
            DataGridTextColumn nombreColumn = new DataGridTextColumn
            {
                Header = "Nombre",
                Binding = new Binding("Nombre"),
                Width = new DataGridLength(1, DataGridLengthUnitType.Star) 
            };
            DataGridTextColumn correoColumn = new DataGridTextColumn
            {
                Header = "Correo",
                Binding = new Binding("Email"),
                Width = new DataGridLength(1, DataGridLengthUnitType.Star)
            };

            // Agregar las columnas al DataGrid
            DataGrid.Columns.Add(idColumn);
            DataGrid.Columns.Add(edadColumn);
            DataGrid.Columns.Add(nombreColumn);
            DataGrid.Columns.Add(correoColumn);
        }




    }


}
