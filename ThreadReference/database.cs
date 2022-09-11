using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadReference
{
    internal class database
    {

        internal List<DTO> GetData(System.Threading.CancellationToken toke)
        {
            var result = new List<DTO>();

            for (int i = 0; i < 5; i++)
            {
                toke.ThrowIfCancellationRequested();

                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }

            return result;
        }
    }
}
