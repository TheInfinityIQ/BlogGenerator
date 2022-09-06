namespace API.DTOs
{
    public record GenerateBlogsInstructionDTO(
        int minTitleLength,
        int maxTitleLength,
        int minContentLength,
        int maxContentLength,
        int numOfBlogs
    );
}
