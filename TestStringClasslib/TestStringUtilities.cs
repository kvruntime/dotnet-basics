namespace TestStringClasslib;

public class TestStringUtilities
{
  [Fact]
  public void TestStartsWithUpperReturnTrue()
  {
    // Given
    var name = "Viktor";
    // When
    var result = StringOperations.StartsWithUpper(name);
    // Then
    Assert.True(result, "This test pass");
  }

  [Fact]
  public void TestStartsWithUpperReturnFalse()
  {
    // Given
    var name = "viktor";
    // When
    var result = StringOperations.StartsWithUpper(name);
    // Then
    Assert.False(result);
  }
}
