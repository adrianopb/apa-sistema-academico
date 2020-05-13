namespace final2.Application
{
    public interface IOutputConverter
    {
        T Map<T>(object source);
    }
}
