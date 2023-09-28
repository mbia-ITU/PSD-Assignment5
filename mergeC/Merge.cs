static int[] Merge (int[] xs, int[] ys){
    int[] output = new int[xs.Length + ys.Length];

    for (int i = 0; i< xs.Length; i++) output[i] = xs[i];
    for (int i = 0; i< ys.Length; i++) output[xs.Length + i] = ys[i];

    Array.Sort(output);
    return output;
}