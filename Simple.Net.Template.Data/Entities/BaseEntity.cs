namespace Simple.Net.Template.Data.Entities
{
    public class BaseEntity: BaseEntity<int>
    {

    }

    public class BaseEntity<TType>
    {
        public virtual TType Key { get; set; }
    }
}