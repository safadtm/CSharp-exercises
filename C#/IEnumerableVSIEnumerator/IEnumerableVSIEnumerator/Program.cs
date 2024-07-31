namespace IEnumerableVSIEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> nums = new List<int>() { 23,45,67,88,90,34};
            nums.Add(600);


            IEnumerable<int> enumerables = nums;
            IEnumerator<int> enumerator1 = enumerables.GetEnumerator();
            


            foreach (var item in enumerables) { 
               Console.WriteLine(item);
            }
            
            enumerator1.MoveNext();
            enumerator1.MoveNext();
            while (enumerator1.MoveNext()) { 
            Console.WriteLine(enumerator1.Current); 
                    }

            enumerator1.Reset();

            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }



        }



    }
}
