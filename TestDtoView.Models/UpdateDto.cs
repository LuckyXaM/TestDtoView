namespace TestDtoView.Models
{
    public class UpdateDto
    {
        public virtual string TestString { get; init; }
        public virtual UpdateUserDto User { get; init; }

        protected UpdateDto()
        {
        }
    }
}
