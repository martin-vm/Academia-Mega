using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]  //Api/productos


//[ApiVersion("1.0")]
//[Route("api/v{version:apiVersion}[controller]")]  //Api/productos

public class ProductosController: ControllerBase
{
    public static readonly List<Producto> _datos = new()
    {   //Aquí sería la lectura de datos en DB

        new Producto{id =  1 , Nombre = "Iphone 16", Precio = 20000.0m },
        new Producto{id =  2 , Nombre = "Samsumg Galaxy 235 Ultra", Precio = 25000.0m }
    };
    
    /*
        --DELETE--
    */



  [HttpDelete("{id}")] //DELETE /api/productos/1
  

    public IActionResult Delete(int id)
    {
        var product = _datos.FirstOrDefault( p => p.id == id ) ;
        if ( product == null ) return NotFound();

        _datos.Remove(product);
        return Ok("El valor se ha eliminado correctamente");

    }



    /*
        --UPDATE--
    */
    [HttpPut("{id}")] //PUT /api/productos/1
    public IActionResult Update(int id , Producto actualizado)
    {        
        var product = _datos.FirstOrDefault( p => p.id == id ) ;
        if ( product == null ) return NotFound();
        product.Nombre = actualizado.Nombre;
        product.Precio = actualizado.Precio;

        //return NoContent();
        return Ok("Producto actualizado exitosamente");
    }



    /*
        --CREATE--
    */
    [HttpPost] //Post  /api/productos
    public ActionResult<Producto> Create( Producto nuevo )
    {
        nuevo.id = _datos.Max( p => p.id ) + 1;
        _datos.Add(nuevo);
        return CreatedAtAction( nameof(GetById) , new { id = nuevo.id }, nuevo  );

    }

    /*
        --READ--
    */

    [HttpGet] // /api/productos //Get
    public ActionResult<IEnumerable<Producto>> GetAll()
    {
        return Ok(_datos);
    }

    [HttpGet ("{id}")] //GET // /api/productos/1

    public ActionResult<Producto> GetById(int id)
    {
        var product = _datos.FirstOrDefault( p => p.id == id ) ;
        if ( product == null ) return NotFound();
        return Ok(product);
    }
}



public class Producto
{
    public int id { get; set;}
    public string Nombre {get; set; } = string.Empty;
    public decimal Precio { get; set; }

}