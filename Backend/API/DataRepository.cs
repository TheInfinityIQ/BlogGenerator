using API.DTOs;
using Bogus;

namespace EasyVue3API;
public class DataRepository
{
    private Faker<Blog> _faker;

    public List<Blog> Blogs { get; set; }

    public DataRepository()
    {
        InitDb();
    }

    public void InitDb()
    {
        Blogs = new List<Blog>();
        InitFaker(1, 3, 5, 10);
        AddBlogs(50);
    }

    public void InitFaker(int minTitleLength, int maxTitleLength, int minContentLength, int maxContentLength)
    {
        _faker = new Faker<Blog>()
            .RuleFor(blog => blog.Title, f => f.Random.Words(f.Random.Int(2, 5)))
            .RuleFor(blog => blog.Content, f => f.Lorem.Sentence(f.Random.Int(3, 10)));
    }

    public void AddBlogs(int numBlogsToAdd)
    {
        Blogs.AddRange(_faker.Generate(numBlogsToAdd));
    }

    public void RegenerateBlogs(GenerateBlogsInstructionDTO dto)
    {
        Blogs = new List<Blog>();
        InitFaker(dto.minTitleLength, dto.maxTitleLength, dto.minContentLength, dto.maxContentLength);
        AddBlogs(dto.numOfBlogs);
    }
}
