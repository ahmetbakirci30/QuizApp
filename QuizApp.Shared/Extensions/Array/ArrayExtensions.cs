namespace QuizApp.Shared.Extensions.Array
{
    public static class ArrayExtensions
    {
        public static void Add<T>(this T[] array, T entity)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = entity;
                    return;
                }
            }
        }
    }
}