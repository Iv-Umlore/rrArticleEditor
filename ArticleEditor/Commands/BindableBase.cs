using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Linq.Expressions;

namespace ArticleEditor
{
    public  class LambdaNPC : INotifyPropertyChanged
    {
       
        void RaisePropertyChanged<T>(Expression<Func<T>> raiser)
        {
            var e = PropertyChanged;
            if (e != null)
            {
                var propName = ((MemberExpression)raiser.Body).Member.Name;
                e(this, new PropertyChangedEventArgs(propName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

