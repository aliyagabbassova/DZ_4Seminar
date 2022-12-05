Console.WriteLine("Введите число");
int[]array=new int[8];
for (int i=0; i<8; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[{0},{1},{2},{3},{4},{5},{6},{7}]",array[0],array[1], array[2], array[3], array[4], array[5], array[6], array[7]);