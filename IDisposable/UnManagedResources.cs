using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableDemo
{
    class UnManagedResources : IDisposable
    {
        public UnManagedResources() 
        { 

        }
        ~UnManagedResources()      //there is no seperate method or keyword to call the finalize method. using destructor only we call call
        {                          //during runtime the destructor is converted into a finalize method.
            CustomDispose();       //If we forgot to call manually the Dispose method ,than the unmanaged resources are never release. 
        }                          //For that we are giving the method name within the destructor
        public void Dispose()
        {
            CustomDispose();
            GC.SuppressFinalize(this);     //supressing the finalize method
        }
        public void CustomDispose()
        {
            //clean logic
        }

    }
}
