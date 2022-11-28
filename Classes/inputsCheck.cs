using TAISEN.Classes;

namespace TAISEN.Classes
{
    public static class InputsCheck
    {
        public static int SimpleIntCheck(int i, SEtape[] GetEtapes )
        {
            try
            {
                i = i % GetEtapes.Count();

            }
            catch( Exception e )
            {
                Console.WriteLine( e.ToString() );
                i = 0;
            }

            return i;
        }


        public static bool SEtapeChek(SEtape[] GetEtapes )
        {
            try
            {
                foreach (SEtape E in GetEtapes)
                {
                    if (!E.Check()) 
                    { 
                        Console.WriteLine("Error during check with: {0} ", E.ToString());
                        throw new InvalidOperationException();
                         
                    }
                    foreach (Atelier A in E.Ateliers)
                    {
                        if (!A.Check())
                        {
                            Console.WriteLine("Error during check with: {0} ", A.ToString());
                            throw new InvalidOperationException();

                        }
                        foreach (Processus P in A.Processus)
                        {
                            if (!P.Check())
                            {
                                Console.WriteLine("Error during check with: {0} ", P.ToString());
                                throw new InvalidOperationException();

                            }
                        }
                    }
                }
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine( e.ToString() );
                return false;
            }
        }
    }
}
