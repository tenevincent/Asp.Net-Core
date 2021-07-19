using Grpc.Core;
using Sqrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 


namespace Server.Services
{
    public class SqrtServiceImpl : Sqrt.SqrtService.SqrtServiceBase
    { 

      

        public override async Task<SqrtReponse> SqrtCalculate(SqrtRequest request, ServerCallContext context)
        {
            await Task.Delay(1500);

            int number = request.Number;

            if (number >= 0)
                return new SqrtReponse() { SquareRoot = Math.Sqrt(number) };
            else
                throw new RpcException(new Status(StatusCode.InvalidArgument, "number < 0"));
        }

    }
}
