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

        public MainWindow()
        {
            InitializeComponent();
            //2b: initialized
            errors = new List<CustomErrors>();

            CustomErrors ce = new CustomErrors("Err001", "Password - Not enought characters");

            //how to add somethiing to a list
            //Adding: listname.Add(object);
            errors.Add(ce);//Adding out instacne of our cutom error

            //we access element in alist the SAME WAY as we do an array
            //Error Code - Error Messaage
            runErrorMessages.Text = $"{errors[0].ErrorCode} - {errors[0].ErrorMessage}";

        }
    }
}