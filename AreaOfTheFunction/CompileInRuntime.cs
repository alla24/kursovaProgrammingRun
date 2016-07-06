using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;


namespace AreaOfTheFunction
{
    class CompileInRuntime //code for compiling user-defined function
    {
        public static MethodInfo CompileFunction(string function)
        {

            string code = @"
    using System;
        namespace UserFunctions
        {                
            public class MyFunction
            {                
                public static double Function(double x)
                {
                    return func_xy;
                }
            }
        }
";//Code for compiling code at runtime
            string finalCode = code.Replace("func_xy", function);//replace string "func_xy" with users function
            CSharpCodeProvider provider = new CSharpCodeProvider();//Create the provider, provides access to objects of C# code generators and compilers
            CompilerParameters parameters = new CompilerParameters();//and parameters of the compiler
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, finalCode);//Compile assembly from the string containing source code, using the specified compiler settings (default)
            Type MyFunction = results.CompiledAssembly.GetType("UserFunctions.MyFunction");//Gets the Type object with the specified name in the compiled assembly instance.
            //members of Type are used to get information about a type declaration, such as the constructors, methods, fields, properties, and events of a class, as well as the module and the assembly in which the class is deployed
            return MyFunction.GetMethod("Function");//Gets a Function method of the current Type - MyFunction, Type returned - MethodInfo.
        }

        public static double CalcFunc(string func,double x)//calls runtime compile with a given function
        {
            MethodInfo function = CompileFunction(func);//returns Function method in MyFunction class
            var result = function.Invoke(null, new object[] { x });//Invokes Function method in MyFunction class, using the specified parameters. Parameter 1 - the object on which to invoke the method, if a method is static, this argument is ignored. Param 2 - an argument list, an array of objects. Returns an object containing the return value of the invoked method
            return (Convert.ToDouble(result));
        }
    }
}
