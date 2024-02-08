Задание 6:
class Instantiator<T> where T : new()
{
    public T Instance { get; set; }
    public Instantiator()
    {
        Instance = new T();
    }
}