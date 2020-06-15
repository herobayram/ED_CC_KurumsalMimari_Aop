using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PostSharp.Aspects;


namespace Core.Aspects.Logging
{
    //IL Weaving(Intermediate Lang/Orta seviye dil Sarmalaması) - 
           //kod build olduğu anda kod içine entegre edilmiş gibi olur. Daha efektif
           //yöntemler : PostSharp-OnMethodBoundaryAspect, 
    //Method Interception  - method üzerine [LogAspect] gibi ibare eklenerek çalıştırılır (reflection çalışır. kodu reflekte ediyor ve araya girer. performans zaafiyeti
    //class ın kullanılabilmesi için çağrıldığı projede de PostSharp ın nuget olarak eklenmesi gerekli.
    [Serializable]
    public class LogAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            //base.OnEntry(args);
            Console.WriteLine("Logged");
        }
    }
}
