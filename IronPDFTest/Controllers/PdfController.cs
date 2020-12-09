using Microsoft.AspNetCore.Mvc;

namespace IronPDFTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        readonly string html = @"<!doctype html>

<html lang=""en"">
<head>
  <meta charset=""utf-8"">

  <title>The HTML5 Herald</title>
  <meta name=""description"" content=""The HTML5 Herald"">
  <meta name=""author"" content=""SitePoint"">

  <link rel=""stylesheet"" href=""css/styles.css?v=1.0"">

</head>

<body>
  <script src=""js/scripts.js""></script>
</body>
</html>";
        [HttpGet]
        public ActionResult GetPassengerPDF(
             [FromServices] IPDFGenerator renderer
            )
        {
            var pdf = renderer.CreatePDF(html);
            if (pdf == null)
            {
                return NotFound();
            }

            return File(pdf, "application/pdf", "Test.pdf");

        }

    }
}
