Задание 6:
class Instantiator<T> where T : new()
{
    public T Instance { get; set; }
    public Instantiator()
    {
        Instance = new T();
    }
}

Задание 9:
1:
SELECT COUNT(*)
FROM students

2:
SELECT COUNT(*)
FROM students
WHERE name = 'Иван'

3:
SELECT COUNT(*)
FROM students
WHERE created_at > '2020.09.01'

4: 
SELECT MAX(c)
FROM (
	SELECT COUNT(id) AS c
	FROM [SCRINTest].[dbo].[students]
	GROUP BY parent_id
) AS result