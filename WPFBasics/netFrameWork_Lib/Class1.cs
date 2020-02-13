using netFrameWork_Lib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFrameWork_Lib
{
    public class Class1 : IBase,IBase2
    {
        
        public int M()
        {
            try
            {
                try
                {
                    throw new NotImplementedException();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }

            catch (NotImplementedException e)
            {
                Console.WriteLine("Error is : " + e);
            }
            catch (Exception ex2)
            {

                Console.WriteLine("Error is : " + ex2);
            }
          
            return 0;
        }

    }
}
