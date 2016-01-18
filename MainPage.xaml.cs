using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "0";
        }

        private void star_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "*";
        }

        private void hash_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "#";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "+";
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "-";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "*";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "/";
        }

        private void percentage_Click(object sender, RoutedEventArgs e)
        {
            calcInput.Text = calcInput.Text + "%";
        }

        private void inputButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
