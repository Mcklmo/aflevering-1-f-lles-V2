namespace _6_Generics
{
    public class Pair<T1, T2>
    {
        public Pair(T1 v1, T2 v2)
        {
            V1 = v1;
            V2 = v2;
        }
        public T1 V1 { get; }
        public T2 V2 { get; }
        public (T2, T1) Swap()
        {
            return (V2, V1);
        }
        public void SetFst<C>(C v1)
        {
            //V1 = v1;
        }
    }
}
