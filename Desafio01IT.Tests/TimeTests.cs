namespace Desafio01IT.Tests
{
    public class TimeTests
    {
        public TimeTestsFixture Fixture { get; set; }

        public TimeTests(TimeTestsFixture fixture)
        {
            Fixture = fixture;
        }
        
        // AAA == Arrange, Act, Assert
        [Fact(DisplayName = "New Time Valid")]
        [Trait("Time", "Time Tests")]
        public void Time_NewTime_ShouldBeValid()
        {
            // Arrange
            var time = Fixture.GetValidTime();

            // Act
            var result = time.IsValid();

            // Assert Fluent Assertions (more expressive)
            result.Should().BeTrue();
            time.ValidationResult.Errors.Should().HaveCount(0);

            // Assert XUnit
            Assert.True(result);
            Assert.Equal(0, time.ValidationResult.Errors.Count);
        }        
    }
}