namespace DatabaseModels
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
