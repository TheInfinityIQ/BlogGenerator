using Bogus;

namespace EasyVue3API;
public class DataRepository
{
	private Faker<Blog> _faker;

	public List<Blog> Blogs { get; set; }
	 
	public DataRepository()
	{
		this.Blogs = new List<Blog>();
		_faker = new Faker<Blog>()
			.RuleFor(blog => blog.Title, f => f.Random.Words(f.Random.Int(2, 5)))
			.RuleFor(blog => blog.Content, f => f.Lorem.Sentence(f.Random.Int(3, 10)));
	}

	public void AddBlogs(int numBlogsToAdd) { 
		Blogs.AddRange(_faker.Generate(numBlogsToAdd));
	}
}
