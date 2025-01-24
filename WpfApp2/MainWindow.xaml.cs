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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private string currentOperator = ""; // For å lagre gjeldende operator
        private double firstNumber = 0; // For å lagre det første tallet
        private bool isOperatorClicked = false; // For å sjekke om en operator er trykket

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AppendNumber("1");
        }

        private void Button_Clic2(object sender, RoutedEventArgs e)
        {
            AppendNumber("2");
        }

        private void Button_Clic3(object sender, RoutedEventArgs e)
        {
            AppendNumber("3");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            AppendNumber("4");
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            AppendNumber("5");
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            AppendNumber("6");
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            AppendNumber("7");
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            AppendNumber("8");
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            AppendNumber("9");
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            AppendNumber("0");
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            SetOperator("+");
        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            SetOperator("-");
        }

        private void Button_Click_gange(object sender, RoutedEventArgs e)
        {
            SetOperator("*");
        }

        private void Button_Click_div(object sender, RoutedEventArgs e)
        {
            SetOperator("/");
        }

        private void Button_Click_Alike(object sender, RoutedEventArgs e)
        {
            CalculateResult();
        }

        private void AppendNumber(string number)
        {
            if (isOperatorClicked)
            {
                textBox.Text = ""; // Tøm tekstboksen hvis en operator er trykket
                isOperatorClicked = false;
            }
            textBox.Text += number;
        }

        private void SetOperator(string op)
        {
            if (double.TryParse(textBox.Text, out double parsedNumber))
            {
                firstNumber = parsedNumber; // Lagre det første tallet
                currentOperator = op; // Lagre operatoren
                isOperatorClicked = true; // Marker at operator er trykket
            }
        }

        private void CalculateResult()
        {
            if (double.TryParse(textBox.Text, out double secondNumber))
            {
                double result = 0;
                switch (currentOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = secondNumber != 0 ? firstNumber / secondNumber : 0;
                        break;
                }
                textBox.Text = result.ToString(); // Vis resultatet i tekstboksen
                currentOperator = ""; // Nullstill operatoren
                isOperatorClicked = false;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Ikke nødvendig å håndtere her
        }
    }
}