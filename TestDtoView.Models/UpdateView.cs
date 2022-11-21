using System;

namespace TestDtoView.Models
{
    public sealed class UpdateView
    {
        public DateTime CreatedAt { get; init; }
        public string TestString { get; init; }
        public UpdateUserView User { get; init; }
    }
}
