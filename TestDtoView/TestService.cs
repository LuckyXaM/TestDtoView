using System;
using TestDtoView.Models;

namespace TestDtoView
{
    public static class TestService
    {
        public static UpdateView Update(UpdateDto updateDto)
        {
            var result = new UpdateView
            {
                CreatedAt = DateTime.UtcNow,
                TestString = updateDto?.TestString,
                User = new()
                {
                    Name = updateDto?.User?.Name
                }
            };

            return result;
        }
    }
}
