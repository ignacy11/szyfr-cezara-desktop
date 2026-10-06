using Avalonia.Controls;
using Avalonia.Interactivity;

namespace szyfr_cezara_desktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    
    private void EncryptTextButtonOnClick(object? sender, RoutedEventArgs e)
    {
        var cipherKey = int.Parse(CipherKeyTextBox.Text);
        var textToEncrypt = TextToBeEncryptedTextBox.Text;
        var resultTextBlock = ResultTextBlock.Text;

        resultTextBlock = textToEncrypt;
    }
}