using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace INTEL8080
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Functions functions = new Functions();
        void Fill()
        {
            AX.Text = "#" + functions.array[0].ToString("x");
            BX.Text = "#" + functions.array[1].ToString("x");
            CX.Text = "#" + functions.array[2].ToString("x");
            DX.Text = "#" + functions.array[3].ToString("x");
        }
        void FillOriginal()
        {
            AX.Text = "#" + functions.arrayOriginal[0].ToString("x");
            BX.Text = "#" + functions.arrayOriginal[1].ToString("x");
            CX.Text = "#" + functions.arrayOriginal[2].ToString("x");
            DX.Text = "#" + functions.arrayOriginal[3].ToString("x");
        }


        public MainWindow()
        {
            InitializeComponent();
            Fill();
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            var CalcType = TypeOfCalc.SelectedIndex;
            var fromwhat = from.SelectedIndex;
            var towhat = to.SelectedIndex;    
            if (CalcType == 0)
            {
                functions.ADD(towhat,fromwhat);
            }
            if (CalcType == 1)
            {
                functions.MOV(towhat, fromwhat);
            }
            if (CalcType == 2)
            {
                functions.SWAP(towhat, fromwhat);
            }
            Fill();
        }



        private void reset_Click(object sender, RoutedEventArgs e)
        {
            FillOriginal();
        }

        private void AddNewRegister_Click(object sender, RoutedEventArgs e)
        {            
            var number = NewRegister.Text;           
            var registerid = RegisterCombo.SelectedIndex;            
            try
            {
                ushort x = ushort.Parse(number);
                functions.CHANGE(registerid, x);
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Za duza liczba!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Nie wpisuj liter!");
            }
            
            Fill();
        }

        private void NewRegister_MouseEnter(object sender, MouseEventArgs e)
        {
            NewRegister.Text = "";
        }


        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void AX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
