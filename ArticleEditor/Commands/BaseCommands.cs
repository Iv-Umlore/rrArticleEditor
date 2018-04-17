using System;
using System.Windows.Input;
using System.Windows.Controls;

namespace ArticleEditor
{
    public class BaseCommands : ICommand
    {
        public BaseCommands(TextBox doc, string tag)
        {
            Doc = doc;
            Tag = tag;
        }
        public void Execute(object parameter)
        {
            if (Doc.SelectedText.Length > 0)
            {
                Doc.SelectedText = string.Format("[{0}]{1}[/{0}]", Tag, Doc.SelectedText);
            }
            else
            {
                Doc.SelectedText = string.Format("[{0}]{1}[/{0}]", Tag, "-текст-");
                Doc.SelectText("-текст-");
            } 
        } 

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged; 
        public TextBox Doc { get; set; } 
        public string Tag { get; set; }
    }
}
