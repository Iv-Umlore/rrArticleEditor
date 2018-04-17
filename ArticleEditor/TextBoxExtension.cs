using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace ArticleEditor
{
    public static class TextBoxExtension
    {
        public static void SelectText(this TextBox doc, string text)
        {

            int index = doc.Text.IndexOf(text, 0);
            if (index != -1)
            {
                doc.Select(index, text.Length);
            }
        }
    }
}
