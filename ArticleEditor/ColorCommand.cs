using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace ArticleEditor
{
    public class ColorCommand : ICommand
    {
        private TextBox doc;

        public ColorCommand(TextBox doc)
        {
            this.doc = doc;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (doc.SelectedText.Length > 0)
            {

                doc.SelectedText = $"[{"color"}=ЦВЕТ]{doc.SelectedText.Trim()}[/{"color"}]";
                doc.SelectText("ЦВЕТ");
            }
            else
            {

                doc.SelectedText = $"[{"color"}=ЦВЕТ]ТЕКСТ[/{"color"}]";
                doc.SelectText("ЦВЕТ");
            }

        }
    }
}