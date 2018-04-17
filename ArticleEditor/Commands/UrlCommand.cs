using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ArticleEditor
{
    public class UrlCommand : ICommand
    {
        public UrlCommand(System.Windows.Controls.TextBox doc)
        {
            this.doc = doc;
        }

        public void Execute(object parameter)
        {
            if (doc.SelectedText.Contains("http") || doc.SelectedText.Contains("www."))
            {
                doc.SelectedText = string.Format("[{0}={1}]-текст-[/{0}]", "url", doc.SelectedText.Trim());
                doc.SelectText("-текст-");
            }
            else
            {
                doc.SelectedText = string.Format("[{0}=-ссылка-]{1}[/{0}]", "url", doc.SelectedText.Trim());
                doc.SelectText("-ссылка-");
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        private System.Windows.Controls.TextBox doc;
    }
}
