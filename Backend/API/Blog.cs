using System;

public class Blog
{
	private static int _uniqueId = 0;
	public int Id { get; set; }
	public string Title { get; set; }
	public string Content { get; set; }
	
	public Blog(string title, string content) : this() { 
		Title = title;
		Content = content;
	}
	
	public Blog()
	{
		Id = _uniqueId++;
	}

}
