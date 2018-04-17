using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ArticleEditor.Commands
{
    public class HrCommand : ICommand
    {
        public HrCommand(System.Windows.Controls.TextBox textBox)
        { 
            this.doc = textBox;
        }

        public void Execute(object parameter)
        {
            doc.SelectedText = string.Format("{0}[hr]{0}", Environment.NewLine);
            doc.SelectionStart = doc.Text.Length;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
        private System.Windows.Controls.TextBox doc;
    }
}
