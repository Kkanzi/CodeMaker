using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KJHCore
{
    public class ReturnVals
    {
        private bool isSucess;
        private string message;

        public bool IsSucess
        {
            get => this.isSucess;
            set => this.isSucess = value;
        }

        public string Message
        {
            get => this.message;
            set => this.message = value;
        }
    }
}
