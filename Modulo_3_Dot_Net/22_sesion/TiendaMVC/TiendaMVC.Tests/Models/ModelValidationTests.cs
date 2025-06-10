using Xunit;
using FluentAssertions;
using TiendaMVC.Models;
using System.ComponentModel.DataAnnotations;

public class ModelValidationTests
{
    [Theory]
    [InlineData("", "pwd")]
    [InlineData("user", "")]

    public void User_Should_Fail_If_Fields_Missing(string user, string pwd)
    {
        var dto = new User { UserName = user, Password = pwd };
        var results = new List<ValidationResult>();
        var context = new ValidationContext(dto);

        var valid = Validator.TryValidateObject(dto, context, results, true);

        valid.Should().BeFalse();
    }
}