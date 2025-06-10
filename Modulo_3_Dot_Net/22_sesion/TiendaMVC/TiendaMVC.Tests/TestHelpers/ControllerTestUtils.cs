using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public static class ControllerTestUtils
{
    public static ControllerContext WithFakeSession(this Controller controller)
    {
        var FakeHttpContext = new DefaultHttpContext
        {
            Session = new FakeSession()
        };

        controller.ControllerContext = new ControllerContext
        {
            HttpContext = FakeHttpContext
        };

        return controller.ControllerContext;
    }
}