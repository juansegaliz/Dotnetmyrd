using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.DTO.Response
{
    public class DefaultResponse<ResponseDTO>
    {
        public int Code { get; set; }
        public ResponseDTO? Data { get; set; }
        public List<string>? Messages { get; set; }
    }
}
