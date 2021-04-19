using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Chapter4.DynamicBindings
{

    public class Duck : System.Dynamic.DynamicObject
    {
        public override bool TryInvokeMember(
          InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " method was called");
            result = null;
            return true;
        }
    }
}
