using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Controls;

namespace ArticleEditor
{
    public class SizeCommand : ICommand
    {
        public SizeCommand(System.Windows.Controls.TextBox doc)
        {
            this.doc = doc;
        }

        public void Execute(object parameter)
        {
            if (doc.SelectedText.Trim().Length == doc.SelectedText.Trim().Where(c => char.IsDigit(c)).Count())
            {
                doc.SelectedText = string.Format("[{0}={1}px]-текст-[/{0}]", "size", doc.SelectedText.Trim());
                doc.SelectText("-текст-");
            }
            else
            {
                doc.SelectedText = string.Format("[{0}=-РАЗМЕР-px]{1}[/{0}]", "size", doc.SelectedText.Trim());
                doc.SelectText("-РАЗМЕР-");
            }
        }

        private System.Windows.Controls.TextBox doc;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

    }


}
