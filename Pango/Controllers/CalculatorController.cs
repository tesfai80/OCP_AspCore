using Microsoft.AspNetCore.Mvc;
using OCP_AspCore.BLL;
using OCP_AspCore.Models;

namespace OCP_AspCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        private Calculator _calculator;
        /// <summary>
        /// for testing razor pages,not used in this application
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //return View();
            return Ok();
        }
        /// <summary>
        /// post function to do all the operations
        /// i keep it simple ,switch case using for different operations
        /// </summary>
        /// <param name="model"></param>
        /// <returns>calc model </returns>
        [HttpPost]
        [Produces("application/json")]
        public CalcModel Post([FromBody] CalcModel model)
        {
            try
            {
                double result = 0D;
                CalcModel calcObj = null;
                if (ModelState.IsValid)
                {
                    switch (model.Operators)
                    {
                        case "+":
                            _calculator = new Add(model);
                            result = _calculator.Calculate();
                            calcObj = new CalcModel
                            {
                                Colored = model.Colored,
                                EvenOrOdd = result % 2 == 0 ? true : false,
                                Result = result
                            };
                            break;
                        case "-":
                            _calculator = new Subtract(model);
                            result = _calculator.Calculate();
                            calcObj = new CalcModel
                            {
                                Colored = model.Colored,
                                EvenOrOdd = result % 2 == 0 ? true : false,
                                Result = result
                            };
                            break;
                        case "*":
                            _calculator = new Multiply(model);
                            result = _calculator.Calculate();
                            calcObj = new CalcModel
                            {
                                Colored = model.Colored,
                                EvenOrOdd = result % 2 == 0 ? true : false,
                                Result = result
                            };
                            break;
                        case "/":
                            _calculator = new Divide(model);
                            result = _calculator.Calculate();
                            calcObj = new CalcModel
                            {
                                Colored = model.Colored,
                                EvenOrOdd = result % 2 == 0 ? true : false,
                                Result = result
                            };
                            break;
                        case "^":
                            _calculator = new Exponent(model);
                            result = _calculator.Calculate();
                            calcObj = new CalcModel
                            {
                                Colored = model.Colored,
                                EvenOrOdd = result % 2 == 0 ? true : false,
                                Result = result
                            };
                            break;
                        default:
                            break;
                    }
                }

                return calcObj;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}