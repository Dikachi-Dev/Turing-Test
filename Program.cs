// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
int[] Soln(int[] a)
{
    int[] res = new int[a.Length];
    int[] arryres = a.OrderBy(x => x).ToArray(); //Order the input 
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < arryres.Length; i++)
    {
        if (!map.ContainsKey(arryres[i]))
        {
            map.Add(arryres[i], i + 1); //map value to their coresponding index
        }
    }
    Console.WriteLine(string.Join(",",a));
    Console.WriteLine(string.Join(",",arryres));

    for (int i = 0; i < a.Length; i++)
    {
        res[i] = map[a[i]]; // return indices of the mapped 
    }

    return res;
}

Console.WriteLine(string.Join(",",Soln(a:[10,30,20,40])));




