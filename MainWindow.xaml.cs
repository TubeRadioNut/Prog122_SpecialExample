using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_SpecialExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //how do we delacar a list
        //array delcaration ; type[]
        //list delcartion; List<type>
        //2a: delcared intitalized in constructor
        List<CustomErrors> errors = new List<CustomErrors>();
        //declared only
        //List<CustomError> error

        public MainWindow()
        {
            InitializeComponent();
            //this creates an EMPTY list of size 10
            //you can pass in an int to delare a different size
            errors = new List<CustomErrors>();
            //If reference object is not INITIAlIzed, it is null
            //null means there is not objsect in memory

            // Adding an object to out list
            //call the list name, then the .Add(object) method
            //Index[0]
            errors.Add(new CustomErrors("Err02", "Format Exception"));//when adding 
            //Add() is always add to the end of the list
            //Index1
            errors.Add(new CustomErrors("Err3", "Divide By Zero"));

            //Insert(index, object)
            //list.Insert(1, new object)
            errors.Insert(1, new CustomErrors("Err04", "IndexOutOfbounds"));

            //----------Removing Items from the list
            // Remove(object)
            //removes an object by referencing the memory addres of object
            //CustomErrors objcetToRemove = errors[0];
            //errors.Remove(objcetToRemove);
            //removeAt(object)
            //Remove an object by index in the list
            //errors.RemoveAt(1);

            //Clear
            //errors.Clear();

            //Accessing Elements --------------
            //you can access an element the same way an array
            //use squae brackts[index]
            CustomErrors currentElement = errors[1];
            runErrorMessages.Text = errors[1].ToString();

            //Tell if an object exists
            //Contains(object)
            //MessageBox.Show(errors.Contains(currentElement).ToString());

            MessageBox.Show(errors.IndexOf(currentElement).ToString());

            


            //runErrorMessages.Text = errors[0].ToString();

            //DisplayErrors(errors);

        }

        public void DisplayErrors(List<CustomErrors> errors)
        {
            runErrorMessages.Text = "";
            foreach (CustomErrors error in errors)
            {
                runErrorMessages.Text += error + "\n";
            }
        }

        public void ListExample()
        {
            //2b: initialized
            errors = new List<CustomErrors>();

            CustomErrors ce = new CustomErrors("Err001", "Password - Not enought characters");

            //how to add somethiing to a list
            //Adding: listname.Add(object);
            errors.Add(ce);//Adding our instacne of our cutom error

            //we access element in alist the SAME WAY as we do an array
            //Error Code - Error Messaage
            //runErrorMessages.Text = $"{errors[0].ErrorCode} - {errors[0].ErrorMessage}"; 
            runErrorMessages.Text = ce.ToString();
        }

    }
}