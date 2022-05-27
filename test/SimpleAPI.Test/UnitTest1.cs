using Xunit;
using SimpleAPI.Controllers;
using System.Collections.Generic;

namespace SimpleAPI.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get();

        
        int result = 0;
        using (IEnumerator<WeatherForecast> enumerator = returnValue.GetEnumerator())
        {
            while (enumerator.MoveNext())
                result++;
        }
        

        //Assert.Equal(5, result);
        Assert.Equal(2, result);
    }
    
}