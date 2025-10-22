using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    public class WorldsDubmestFunctionTests
    {
        //Naming Convention = ClassName_MethodName_ExpectedResult
        public static void WorldDubestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange
                int num = 0;
                WorldDubestFunction worldsDumbest = new WorldDubestFunction();

                //Act
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert
                if (result == "Pikachu")
                {
                    Console.WriteLine("TEST PASSED: WorldDubestFunction.ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("TEST FAILED: WorldDubestFunction.ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Test failed: " + ex.Message);
            }
        }
    }
}
