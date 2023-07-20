using Crud.Model;
using Crud.Model.CustomerService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Crud.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private int id;
        private int edad;
        private string nombre;
        private string correo;

        private ObservableCollection<Customer> lista;


        ServiceAdapter serv;

        public ICommand SeleccionarPersonaCommand { get; }//Identificar Item del datagrid
        public ICommand GuardarCommand { get; }//Comando para el botón Guardar
        public ICommand LimpiarCommand { get; } // Comando para el botón Nuevo
        public ICommand EliminarCommand { get; }// Comando para eliminar

        public ICommand GuardarSQLCommand { get; }//Comando para el botón Guardar
        public int Id
        {
            get { return id; }
            set
            {
                if (value == id)
                    return;
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value == edad)
                    return;
                edad = value;
                OnPropertyChanged("edad");
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value ==  nombre)
                    return;
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                if (value == correo)
                    return;
                correo = value;
                OnPropertyChanged("Correo");
            }
        }

        public ObservableCollection<Customer> Lista
        {
            get { return lista; }
            set
            {
               
                lista = value;
                OnPropertyChanged(nameof(lista));
            }
        }
        public MainViewModel()
        {
           
            GuardarCommand = new RelayCommand(Save,CanSave);
            LimpiarCommand = new RelayCommand(Clean,CanClean);
            SeleccionarPersonaCommand = new RelayCommand(SelectPerson);
            EliminarCommand = new RelayCommand(Delete, CanDelete);
            GuardarSQLCommand = new RelayCommand(saveSQL);

            Lista = new ObservableCollection<Customer>();
            serv = new ServiceAdapter();

        }
        private void Save(object parameter)
        {
            // Verificar si el ID ya existe
            bool idExistente = Lista.Any(p => p.Id == Id);

            if (idExistente)
            {
                MessageBox.Show("El ID ya existe. Por favor, elija un ID único.", "ID duplicado", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Customer nuevaPersona = new Customer();
            nuevaPersona.Nombre = nombre;
            nuevaPersona.Email = correo;
            nuevaPersona.Edad = edad;

            Lista.Add(nuevaPersona);
            //Limpiar Textbox
            Id = 0;
            Edad =0;
            Nombre = "";
            Correo = "";
        }
        private bool CanSave(object parameter)
        {
            // Verificar campos requeridos llenos para habilitar el botón Guardar
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Correo) && Id != 0 && Edad > 0 && Edad < 100;
        }
        private void Clean(object parameter)
        {
            // Limpiar TextBox
            Id = 0;
            Edad = 0;
            Nombre = "";
            Correo = "";
        }
        private bool CanClean(object parameter)
        {
            // Verificar TextBox no  vacíos para habilitar el botón Limpiar
            return !string.IsNullOrEmpty(Nombre) || !string.IsNullOrEmpty(Correo) || Id != 0 || Edad != 0;
        }

        private void SelectPerson(object parameter)
        {
            if (parameter is Customer personaSeleccionada)
            {
                // Cargar datos en los TextBox
                Id = personaSeleccionada.Id;
                Edad = personaSeleccionada.Edad;
                Nombre = personaSeleccionada.Nombre;
                Correo = personaSeleccionada.Email;
            }
        }


        private void Delete(object parameter)
        {
            if (parameter is Customer personaSeleccionada)
            {
                MessageBoxResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este elemento?", "Confirmar eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Lista.Remove(personaSeleccionada);
                    Clean(null);
                }
            }
        }

        private bool CanDelete(object parameter)
        {
            return parameter is Person;
        }

        public void saveSQL(object parameter)
        {
            if (Lista.Count > 0)
            {
                if (serv.insertCustomerMasiveService(Lista))
                {
                    MessageBox.Show("Registros guardados en DB.", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                    Lista.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los datos masivamente.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                MessageBox.Show("La lista se esta vacía, rellene datos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}

