using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TiendaMVC.Controllers;
using TiendaMVC.Models;
using TiendaMVC.Services;
using Xunit;

public class ProductosControllerTests
{
    [Fact]
    public async Task Index_ReturnsViewWithProductList()
    {
        var mockAPI = new Mock<ApiClient>();
        mockAPI.Setup(s => s.GetProductosAsync())
            .ReturnsAsync(new List<Producto>
            {
                new Producto{Id=1, Nombre="iPhone 16 Pro Max" , Precio=2599.00M}
            });

        var moqObj = new ProductosController(mockAPI.Object);

        var result = await moqObj.Index();

        // Assert
        result.Should().BeOfType<ViewResult>()
            .Which.Model.Should().BeAssignableTo<IEnumerable<Producto>>()
            .And.As<IEnumerable<Producto>>()
            .Should().HaveCount(1);

    }
}