using System;
using System.Linq.Expressions;
using System.Windows.Input;

namespace Cirrious.MvvmCross.AutoView.Auto.Dialog
{
    public class TimeAuto : ValueElementAuto
    {
        public TimeAuto(string key = null, Expression<Func<object>> bindingExpression = null, string converter = null, string converterParameter = null, string value = null, string caption = null, string onlyFor = null, string notFor = null, Expression<Func<ICommand>> selectedCommand = null, string layoutName = null)
            : base(key ?? "Time", bindingExpression, converter, converterParameter, value, caption, onlyFor, notFor, selectedCommand, layoutName)
        {
        }
    }
}