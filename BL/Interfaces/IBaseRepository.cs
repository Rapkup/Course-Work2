namespace ArpachTax
{
    internal interface IBaseRepository<T>
    {
        bool Create(T entity);
        T Get(int id);
        IEnumerable<T> Select();

        bool Delete(T entity);


    }
}
