using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace MvvmCross.Ph4ct3x.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>
    {
        public abstract void Prepare(TParameter parameter);
    }
}
