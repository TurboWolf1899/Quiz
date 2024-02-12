using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyQuiz
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
        private void About_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
      
        }
        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
          
        }
        private void Radio4_Checked(object sender, RoutedEventArgs e)
        {
       
        }
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        private void Predaj_Click(object sender, RoutedEventArgs e)
        {
            int ans = 0;
            if(Radio3.IsChecked==true)
            {
                ans++;
            }
            if(Checkbox2.IsChecked==true)
            {
                ans++;
            }
            if(ComboBox1.SelectedIndex==0)
            {
                ans++;
            }
            Rezultat.Text = ans.ToString()+"/3";

        }

        private void MenuBarItem_ContextCanceled(UIElement sender, RoutedEventArgs args)
        {

        }
    }
}
