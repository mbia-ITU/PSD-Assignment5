static int[] Merge (int[] xs, int[] ys){
    int[] output = new int[xs.Length + ys.Length];

    for (int i = 0; i< xs.Length; i++) output[i] = xs[i];
    for (int i = 0; i< ys.Length; i++) output[xs.Length + i] = ys[i];

    Array.Sort(output);
    return output;
}


int[] a = { 1, 2 , 66};
int[] b = { -100, 2 , 50};
foreach(var x in Merge(a,b)){ Console.WriteLine(x);}