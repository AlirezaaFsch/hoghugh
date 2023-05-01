using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoghugh.View
{
    interface MainView
    {
        public void setViewModel(object obj);
        public object getInput();
        public object initView();
        public object onOk();
        public object onError();

    }
}
